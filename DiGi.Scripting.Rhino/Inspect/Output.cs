using DiGi.Rhino.Core.Classes;
using DiGi.Scripting.Classes;
using DiGi.Scripting.Rhino.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Scripting.Rhino.Inspect
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the value of the script output as a <see cref="GooObject"/>.
        /// </summary>
        /// <param name="output">The script output to inspect.</param>
        /// <returns>A <see cref="GooObject"/> wrapping the value, or <see langword="null"/> if the output is null.</returns>
        [Inspect("Value", "Value", "Value")]
        public static GooObject? Value(this Output? output)
        {
            if (output == null)
            {
                return null;
            }

            return new GooObject(output.Value);
        }

        /// <summary>
        /// Extracts the name of the script output as a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="output">The script output to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the name, or <see langword="null"/> if the output is null.</returns>
        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this Output? output)
        {
            if (output == null)
            {
                return null;
            }

            return new GH_String(output.Name);
        }

        /// <summary>
        /// Extracts the variable type of the script output as a <see cref="GooVariableType"/>.
        /// </summary>
        /// <param name="output">The script output to inspect.</param>
        /// <returns>A <see cref="GooVariableType"/> wrapping the variable type, or <see langword="null"/> if the output is null.</returns>
        [Inspect("VariableType", "VariableType", "VariableType")]
        public static GooVariableType? VariableType(this Output? output)
        {
            if (output == null)
            {
                return null;
            }

            return new GooVariableType(output.VariableType);
        }
    }
}