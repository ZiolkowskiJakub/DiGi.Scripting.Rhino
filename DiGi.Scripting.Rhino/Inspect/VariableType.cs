using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Scripting.Rhino.Inspect
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the system type from a <see cref="Scripting.Classes.VariableType" /> and wraps it in a <see cref="GooType" /> for Grasshopper inspection.
        /// </summary>
        /// <param name="variableType">The variable type to inspect.</param>
        /// <returns>A <see cref="GooType" /> containing the system type, or <see langword="null" /> if the input is null.</returns>
        [Inspect("Type", "Type", "Type")]
        public static GooType? Type(this Scripting.Classes.VariableType? variableType)
        {
            if (variableType == null)
            {
                return null;
            }

            return new GooType(variableType.Type);
        }

        /// <summary>
        /// Extracts the name from a <see cref="Scripting.Classes.VariableType" /> and wraps it in a <see cref="GH_String" /> for Grasshopper inspection.
        /// </summary>
        /// <param name="variableType">The variable type to inspect.</param>
        /// <returns>A <see cref="GH_String" /> containing the name, or <see langword="null" /> if the input is null.</returns>
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