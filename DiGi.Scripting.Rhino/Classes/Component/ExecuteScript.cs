using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Scripting.Rhino.Classes
{
    public class ExecuteScript : VariableParameterComponent
    {
        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public ExecuteScript()
          : base("Scripting.ExecuteScript", "Scripting.ExecuteScript",
              "Execute Script",
              "DiGi", "DiGi.Scripting")
        {
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("23aa1124-1c2f-4371-89de-7c2a2d27f646");

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
                    new Param(new GooScriptParam() { Name = "Script", NickName = "Script", Description = "Script", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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
                    new Param(new GooScriptParam() { Name = "Script", NickName = "Script", Description = "Script", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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

            index = Params.IndexOfInputParam("Street");
            string? street = null;
            if (index == -1 || !dataAccess.GetData(index, ref street))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            DiGi.Core.Classes.Address address = new(street, null, null, DiGi.Core.Enums.CountryCode.Undefined);

            index = Params.IndexOfOutputParam("Address");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooAddress(address));
            }

        }
    }
}
