using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Scripting.CSharp.Rhino.Classes
{
    /// <summary>
    /// Provides assembly information for the DiGi.Scripting.CSharp.Rhino Grasshopper plugin.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the GHA library.
        /// </summary>
        public override string Name => "DiGi.Scripting.CSharp.Rhino";

        /// <summary>
        /// Gets a 24x24 pixel bitmap to represent this GHA library.
        /// </summary>
        public override Bitmap? Icon => null;

        /// <summary>
        /// Gets a short string describing the purpose of this GHA library.
        /// </summary>
        public override string Description => "";

        /// <summary>
        /// Gets the unique identifier for this assembly.
        /// </summary>
        public override Guid Id => new("2eeb2b56-e435-420b-877d-6153f36c8a2b");

        /// <summary>
        /// Gets the name of the author or company.
        /// </summary>
        public override string AuthorName => "Jakub Ziolkowski";

        /// <summary>
        /// Gets the preferred contact details for the author.
        /// </summary>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}