using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Scripting.CSharp.Rhino.Classes
{
    public class RhinoInfo : GH_AssemblyInfo
    {
        public override string Name => "DiGi.Scripting.CSharp.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap? Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new("2eeb2b56-e435-420b-877d-6153f36c8a2b");

        //Return a string identifying you or your company.
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}