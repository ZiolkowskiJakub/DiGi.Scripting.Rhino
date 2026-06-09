using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    /// <summary>
    /// A Goo wrapper for a serializable script input.
    /// </summary>
    public class GooInput : GooObject<Interfaces.ISerializableInput?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooInput"/> class.
        /// </summary>
        public GooInput()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooInput"/> class with a specified serializable input.
        /// </summary>
        /// <param name="serializableInput">The serializable input to wrap.</param>
        public GooInput(Interfaces.ISerializableInput? serializableInput)
            : base()
        {
            Value = serializableInput;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooInput"/> object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooInput"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooInput(Value);
        }
    }

    /// <summary>
    /// A persistent Grasshopper parameter for handling <see cref="GooInput"/> objects.
    /// </summary>
    public class GooInputParam : GooPresistentParam<GooInput, Interfaces.ISerializableInput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooInputParam"/> class.
        /// </summary>
        public GooInputParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique identifier for the <see cref="GooInputParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("db843842-0b39-4610-8923-3bd30e935676");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}