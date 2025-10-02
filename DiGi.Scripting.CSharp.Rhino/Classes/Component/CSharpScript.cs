using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Scripting.Classes;
using DiGi.Scripting.Rhino.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Scripting.CSharp.Rhino.Classes
{
    public class CSharpScript : VariableParameterComponent
    {
        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public CSharpScript()
          : base("Scripting.CSharpScript", "Scripting.CSharpScript",
              "Create CSharp Script",
              "DiGi", "DiGi.Scripting")
        {
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("9d62aa44-9ca5-487b-8f03-6725874e33e3");

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
                    new Param(new GooCodeParam() { Name = "Code", NickName = "Code", Description = "Code", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "References", NickName = "References", Description = "References", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "Imports", NickName = "Imports", Description = "Imports", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Binding),
                    new Param(new GooVariableTypeParam() { Name = "InputVariableTypes", NickName = "InputVariableTypes", Description = "Input VariableTypes", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Binding),
                    new Param(new GooVariableTypeParam() { Name = "OutputVariableTypes", NickName = "OutputVariableTypes", Description = "Output VariableTypes", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Binding),
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

            index = Params.IndexOfInputParam("Code");
            Code? code = null;
            if (index == -1 || !dataAccess.GetData(index, ref code))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            List<string> references = [];
            index = Params.IndexOfInputParam("References");
            if (index != -1)
            {
                dataAccess.GetDataList(index, references);
            }

            List<string> imports = [];
            index = Params.IndexOfInputParam("Imports");
            if (index != -1)
            {
                dataAccess.GetDataList(index, imports);
            }

            List<VariableType> inputVariableTypes = [];
            index = Params.IndexOfInputParam("InputVariableTypes");
            if (index != -1)
            {
                dataAccess.GetDataList(index, inputVariableTypes);
            }

            List<VariableType> outputVariableTypes = [];
            index = Params.IndexOfInputParam("OutputVariableTypes");
            if (index != -1)
            {
                dataAccess.GetDataList(index, outputVariableTypes);
            }

            CSharp.Classes.Script script = new CSharp.Classes.Script(code, inputVariableTypes, outputVariableTypes);

            index = Params.IndexOfOutputParam("Script");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooScript(script));
            }

        }
    }
}
