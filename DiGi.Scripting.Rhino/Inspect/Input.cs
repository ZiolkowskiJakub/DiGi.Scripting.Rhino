using DiGi.Rhino.Core.Classes;
using DiGi.Scripting.Rhino.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Scripting.Rhino.Inspect
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the value from the specified script input and wraps it in a <see cref="GooObject"/>.
        /// </summary>
        /// <param name="input">The script input variable to inspect.</param>
        /// <returns>A <see cref="GooObject"/> wrapping the value, or <see langword="null"/> if the input is null.</returns>
        [Inspect("Value", "Value", "Value")]
        public static GooObject? Value(this Scripting.Classes.Input? input)
        {
            if (input == null)
            {
                return null;
            }

            return new GooObject(input.Value);
        }

        /// <summary>
        /// Extracts the name from the specified script input and wraps it in a <see cref="GH_String"/>.
        /// </summary>
        /// <param name="input">The script input variable to inspect.</param>
        /// <returns>A <see cref="GH_String"/> wrapping the name, or <see langword="null"/> if the input is null.</returns>
        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this Scripting.Classes.Input? input)
        {
            if (input == null)
            {
                return null;
            }

            return new GH_String(input.Name);
        }

        /// <summary>
        /// Extracts the variable type from the specified script input and wraps it in a <see cref="GooVariableType"/>.
        /// </summary>
        /// <param name="input">The script input variable to inspect.</param>
        /// <returns>A <see cref="GooVariableType"/> wrapping the variable type, or <see langword="null"/> if the input is null.</returns>
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