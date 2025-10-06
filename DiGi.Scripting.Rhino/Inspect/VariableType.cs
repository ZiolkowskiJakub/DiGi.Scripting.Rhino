using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Scripting.Rhino.Inspect
{
    public static partial class Inspect
    {
        [Inspect("Type", "Type", "Type")]
        public static GooType? Type(this Scripting.Classes.VariableType? variableType)
        {
            if (variableType == null)
            {
                return null;
            }

            return new GooType(variableType.Type);
        }

        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this Scripting.Classes.VariableType? variableType)
        {
            if (variableType == null)
            {
                return null;
            }

            return new GH_String(variableType.Name);
        }
    }
}

