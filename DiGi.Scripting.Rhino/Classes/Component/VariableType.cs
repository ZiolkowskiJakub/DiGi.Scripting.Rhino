using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Scripting.Rhino.Classes
{
    public class VariableType : VariableParameterComponent
    {
        /// <summary>
        /// Initializes a new instance of object.
        /// </summary>
        public VariableType()
          : base("Scripting.VariableType", "Scripting.VariableType",
              "Create VariableType",
              "DiGi", "DiGi.Scripting")
        {
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("ca762059-ecd2-4fdb-b1d1-fc2a7e5f9d08");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "Name", NickName = "Name", Description = "Name", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooTypeParam() { Name = "Type", NickName = "Type", Description = "Type", Access = GH_ParamAccess.item, Optional = true }, ParameterVisibility.Voluntary),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooVariableTypeParam() { Name = "VariableType", NickName = "VariableType", Description = "VariableType", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("Name");
            string? name = null;
            if (index == -1 || !dataAccess.GetData(index, ref name))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Type");
            Type? type = null;
            if (index != -1)
            {
                if (!dataAccess.GetData(index, ref type))
                {
                    type = null;
                }
            }

            if (type == null)
            {
                type = typeof(object);
            }

            Scripting.Classes.VariableType variableType = new(name, type);

            index = Params.IndexOfOutputParam("VariableType");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooVariableType(variableType));
            }
        }
    }
}