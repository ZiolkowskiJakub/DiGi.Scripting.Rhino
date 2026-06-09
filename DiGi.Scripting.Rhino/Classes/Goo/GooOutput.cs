using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo object wrapper for a serializable output value.
    /// </summary>
    public class GooOutput : GooObject<Interfaces.ISerializableOutput?>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooOutput"/> class.
        /// </summary>
        public GooOutput()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooOutput"/> class with a specified serializable output.
        /// </summary>
        /// <param name="serializableOutput">The serializable output value to wrap.</param>
        public GooOutput(Interfaces.ISerializableOutput? serializableOutput)
            : base()
        {
            Value = serializableOutput;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooOutput"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooOutput(Value);
        }
    }

    /// <summary>
    /// Represents a persistent Grasshopper parameter for serializable output values.
    /// </summary>
    public class GooOutputParam : GooPresistentParam<GooOutput, Interfaces.ISerializableOutput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooOutputParam"/> class.
        /// </summary>
        public GooOutputParam()
            : base()
        {
        }

        /// <summary>
        /// Gets the unique identifier for the component.
        /// </summary>
        public override Guid ComponentGuid => new("4072a24d-700d-475c-8874-dac85ec1e0f0");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}