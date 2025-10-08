using DiGi.Rhino.Core.Classes;
using GH_IO.Serialization;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    public class GooOutput : GooObject<Interfaces.ISerializableOutput?>
    {
        public GooOutput()
            : base()
        {
        }

        public GooOutput(Interfaces.ISerializableOutput? serializableOutput)
            : base()
        {
            Value = serializableOutput;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooOutput(Value);
        }
    }

    public class GooOutputParam : GooPresistentParam<GooOutput, Interfaces.ISerializableOutput>
    {
        public GooOutputParam()
            : base()
        {
        }

        public override Guid ComponentGuid => new("4072a24d-700d-475c-8874-dac85ec1e0f0");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
