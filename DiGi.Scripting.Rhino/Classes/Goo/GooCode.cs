using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for the <see cref="Scripting.Classes.Code" /> class, enabling its use within Grasshopper's data pipeline and serialization.
    /// </summary>
    public class GooCode : GooSerializableObject<Scripting.Classes.Code>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooCode" /> class.
        /// </summary>
        public GooCode()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooCode" /> class with the specified code object.
        /// </summary>
        /// <param name="code">The <see cref="Scripting.Classes.Code" /> object to wrap.</param>
        public GooCode(Scripting.Classes.Code? code)
            : base()
        {
            Value = code;
        }

        /// <summary>
        /// Attempts to cast the specified source object into a <see cref="GooCode" /> value.
        /// </summary>
        /// <param name="source">The object to cast from.</param>
        /// <returns>True if the casting was successful; otherwise, false.</returns>
        public override bool CastFrom(object? source)
        {
            if (source is Scripting.Classes.Code code)
            {
                Value = code;
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
                Value = new Scripting.Classes.Code(@string);
                return true;
            }

            return base.CastFrom(source);
        }

        /// <summary>
        /// Attempts to cast the Goo object to the specified type.
        /// </summary>
        /// <typeparam name="Y">The target type for casting.</typeparam>
        /// <param name="target">A reference to the target variable.</param>
        /// <returns>True if the casting was successful; otherwise, false.</returns>
        public override bool CastTo<Y>(ref Y target)
        {
            return base.CastTo(ref target);
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooCode" /> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo" /> instance containing a copy of the value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooCode(Value);
        }
    }

    /// <summary>
    /// Represents a Grasshopper parameter for handling <see cref="GooCode" /> objects and their underlying <see cref="Scripting.Classes.Code" /> values.
    /// </summary>
    public class GooCodeParam : GooSerializablePresistentParam<GooCode, Scripting.Classes.Code>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooCodeParam" /> class.
        /// </summary>
        public GooCodeParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique identifier for the <see cref="GooCodeParam" /> component.
        /// </summary>
        public override Guid ComponentGuid => new("73bd4f81-d68f-41a9-a2fd-428fd84aed54");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}