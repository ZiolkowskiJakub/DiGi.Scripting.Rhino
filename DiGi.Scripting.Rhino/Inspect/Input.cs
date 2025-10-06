using DiGi.Rhino.Core.Classes;
using DiGi.Scripting.Rhino.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Scripting.Rhino.Inspect
{
    public static partial class Inspect
    {
        [Inspect("Value", "Value", "Value")]
        public static GooObject? Value(this Scripting.Classes.Input? input)
        {
            if (input == null)
            {
                return null;
            }

            return new GooObject(input.Value);
        }

        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this Scripting.Classes.Input? input)
        {
            if (input == null)
            {
                return null;
            }

            return new GH_String(input.Name);
        }

        [Inspect("VariableType", "VariableType", "VariableType")]
        public static GooVariableType? VariableType(this Scripting.Classes.Input? input)
        {
            if (input == null)
            {
                return null;
            }

            return new GooVariableType(input.VariableType);
        }
    }
}

