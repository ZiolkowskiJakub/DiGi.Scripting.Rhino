using DiGi.Rhino.Core.Classes;
using DiGi.Scripting.Interfaces;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    public class GooScript : GooSerializableObject<IScript>
    {
        public GooScript()
            : base()
        {
        }

        public GooScript(IScript? script)
            : base()
        {
            Value = script;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooScript(Value);
        }
    }

    public class GooScriptParam : GooSerializablePresistentParam<GooScript, IScript>
    {
        public override Guid ComponentGuid => new("cf026259-ff81-4f88-baf5-9e6008fb596b");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooScriptParam()
            : base()
        {
        }
    }
}
