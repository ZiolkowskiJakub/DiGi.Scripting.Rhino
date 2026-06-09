using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for a <see cref="Scripting.Classes.VariableType" />.
    /// </summary>
    public class GooVariableType : GooSerializableObject<Scripting.Classes.VariableType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooVariableType" /> class.
        /// </summary>
        public GooVariableType()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooVariableType" /> class with the specified variable type.
        /// </summary>
        /// <param name="variableType">The variable type to wrap.</param>
        public GooVariableType(Scripting.Classes.VariableType? variableType)
            : base()
        {
            Value = variableType;
        }

        /// <summary>
        /// Attempts to cast the specified source object to a <see cref="GooVariableType" />.
        /// </summary>
        /// <param name="source">The source object to cast from.</param>
        /// <returns>True if the casting was successful; otherwise, false.</returns>
        public override bool CastFrom(object? source)
        {
            if (source is Scripting.Classes.VariableType variableType)
            {
                Value = variableType;
                return true;
            }

            object? source_Temp = source;
            if (source is IGH_Goo gh_Goo)
            {
                if (DiGi.Rhino.Core.Query.TryGetValue(gh_Goo, out object? source_Temp_Temp))
                {
                    source_Temp = source_Temp_Temp;
                }
            }

            if (source_Temp is string @string)
            {
                Value = new Scripting.Classes.VariableType(@string, typeof(object));
                return true;
            }

            return base.CastFrom(source);
        }

        /// <summary>
        /// Attempts to cast the Goo object to the specified target type.
        /// </summary>
        /// <typeparam name="Y">The target type.</typeparam>
        /// <param name="target">A reference to the target variable.</param>
        /// <returns>True if the casting was successful; otherwise, false.</returns>
        public override bool CastTo<Y>(ref Y target)
        {
            return base.CastTo(ref target);
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooVariableType" /> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooVariableType(Value);
        }
    }

    /// <summary>
    /// Represents a persistent parameter for <see cref="GooVariableType" />.
    /// </summary>
    public class GooVariableTypeParam : GooSerializablePresistentParam<GooVariableType, Scripting.Classes.VariableType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooVariableTypeParam" /> class.
        /// </summary>
        public GooVariableTypeParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("5f93ffc8-bb99-43f5-9f4e-ce4570a78634");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}