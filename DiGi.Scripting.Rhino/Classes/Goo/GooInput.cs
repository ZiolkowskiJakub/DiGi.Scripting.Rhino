using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    public class GooInput : GooObject<Interfaces.ISerializableInput>
    {
        public GooInput()
            : base()
        {
        }

        public GooInput(Interfaces.ISerializableInput? serializableInput)
            : base()
        {
            Value = serializableInput;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooInput(Value);
        }
    }

    public class GooInputParam : GooPresistentParam<GooInput, Interfaces.ISerializableInput>
    {
        public GooInputParam()
            : base()
        {
        }

        public override Guid ComponentGuid => new("db843842-0b39-4610-8923-3bd30e935676");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
