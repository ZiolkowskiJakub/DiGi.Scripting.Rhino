using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Scripting.Rhino.Classes
{
    public class GooVariableType : GooSerializableObject<Scripting.Classes.VariableType>
    {
        public GooVariableType()
            : base()
        {
        }

        public GooVariableType(Scripting.Classes.VariableType? variableType)
            : base()
        {
            Value = variableType;
        }

        public override bool CastFrom(object? source)
        {
            if (source is Scripting.Classes.VariableType variableType)
            {
                Value = variableType;
                return true;
            }

            object? source_Temp = source;
            if (source is IGH_Goo gh_Goo)
            {
                if (DiGi.Rhino.Core.Query.TryGetValue(gh_Goo, out object? source_Temp_Temp))
                {
                    source_Temp = source_Temp_Temp;
                }
            }

            if (source_Temp is string @string)
            {
                Value = new Scripting.Classes.VariableType(@string, typeof(object));
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
            return new GooVariableType(Value);
        }
    }

    public class GooVariableTypeParam : GooSerializablePresistentParam<GooVariableType, Scripting.Classes.VariableType>
    {
        public GooVariableTypeParam()
            : base()
        {
        }

        public override Guid ComponentGuid => new("5f93ffc8-bb99-43f5-9f4e-ce4570a78634");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}