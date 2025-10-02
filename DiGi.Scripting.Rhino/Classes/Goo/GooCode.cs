using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    public class GooCode : GooSerializableObject<Scripting.Classes.Code>
    {
        public GooCode()
            : base()
        {
        }

        public GooCode(Scripting.Classes.Code? code)
            : base()
        {
            Value = code;
        }

        public override bool CastFrom(object source)
        {
            if (source is Scripting.Classes.Code)
            {
                Value = (Scripting.Classes.Code)source;
                return true;
            }

            object source_Temp = source;
            if (source is IGH_Goo gh_Goo)
            {
                source_Temp = (gh_Goo as dynamic).Value;
            }

            if (source_Temp is Scripting.Classes.Code)
            {
                Value = (Scripting.Classes.Code)source;
                return true;
            }

            if (source_Temp is string @string)
            {
                Value = new Scripting.Classes.Code(@string);
                return true;
            }

            return base.CastFrom(source);
        }

        public override bool CastTo<Y>(ref Y target)
        {
            return base.CastTo(ref target);
        }
        public override IGH_Goo Duplicate()
        {
            return new GooCode(Value);
        }
    }

    public class GooCodeParam : GooPresistentParam<GooCode, Scripting.Classes.Code>
    {
        public GooCodeParam()
            : base()
        {
        }

        public override Guid ComponentGuid => new("73bd4f81-d68f-41a9-a2fd-428fd84aed54");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}
