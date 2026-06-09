using DiGi.Rhino.Core.Classes;
using DiGi.Scripting.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    /// <summary>
    /// Represents a Goo wrapper for an <see cref="IScript"/> object.
    /// </summary>
    public class GooScript : GooSerializableObject<IScript>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooScript"/> class.
        /// </summary>
        public GooScript()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooScript"/> class with a specified script.
        /// </summary>
        /// <param name="script">The script object to wrap.</param>
        public GooScript(IScript? script)
            : base()
        {
            Value = script;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo script object.
        /// </summary>
        /// <returns>A new instance of <see cref="GooScript"/> containing the same value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooScript(Value);
        }
    }

    /// <summary>
    /// Represents a persistent parameter for <see cref="GooScript"/> objects.
    /// </summary>
    public class GooScriptParam : GooSerializablePresistentParam<GooScript, IScript>
    {
        /// <summary>
        /// Gets the unique identifier for the script component.
        /// </summary>
        public override Guid ComponentGuid => new("cf026259-ff81-4f88-baf5-9e6008fb596b");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooScriptParam"/> class.
        /// </summary>
        public GooScriptParam()
            : base()
        {
        }
    }
}