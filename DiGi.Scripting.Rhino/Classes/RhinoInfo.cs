using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Scripting.Rhino.Classes
{
    public class RhinoInfo : GH_AssemblyInfo
    {
        public override string Name => "DiGi.Scripting.Rhino";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap? Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new("9f692a10-5248-4a31-88b5-f0c3c2dba17d");

        //Return a string identifying you or your company.
        public override string AuthorName => "Jakub Ziolkowski";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}