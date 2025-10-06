using DiGi.Rhino.Core.Classes;
using DiGi.Scripting.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Scripting.Rhino.Inspect
{
    public static partial class Inspect
    {
        [Inspect("Value", "Value", "Value")]
        public static GooObject? Value(this Output? output)
        {
            if (output == null)
            {
                return null;
            }

            return new GooObject(output.Value);
        }

        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this Output? output)
        {
            if (output == null)
            {
                return null;
            }

            return new GH_String(output.Name);
        }
    }
}

