using DiGi.GIS.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Scripting.Classes;
using DiGi.Scripting.Interfaces;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Scripting.Rhino.Classes
{
    public class ExecuteScript : VariableParameterComponent
    {
        /// <summary>
        /// Initializes a new instance of object.
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
                    new Param(new GooInputParam() { Name = "Inputs", NickName = "Inputs", Description = "Inputs", Access = GH_ParamAccess.list, Optional = true }, ParameterVisibility.Binding),
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
                    new Param(new Grasshopper.Kernel.Parameters.Param_Boolean() { Name = "Succeeded", NickName = "Succeeded", Description = "Succeeded", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooOutputParam() { Name = "Outputs", NickName = "Outputs", Description = "Outputs", Access = GH_ParamAccess.list }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "ExceptionMessage", NickName = "ExceptionMessage", Description = "Exception message", Access = GH_ParamAccess.item }, ParameterVisibility.Binding)
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

            index = Params.IndexOfInputParam("Script");
            Script? script = null;
            if (index == -1 || !dataAccess.GetData(index, ref script) || script == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Inputs");
            List<ISerializableInput> serializableInputs = [];
            if (index != -1)
            {
                if (!dataAccess.GetDataList(index, serializableInputs))
                {
                    serializableInputs = [];
                }
            }

            Response? response = script.Execute(serializableInputs);

            index = Params.IndexOfOutputParam("Succeeded");
            if(index != -1)
            {
                dataAccess.SetData(index, response != null && response.Succeeded);
            }

            Exception? exception = response?.Exception;

            index = Params.IndexOfOutputParam("ExceptionMessage");
            if (index != -1)
            {
                string? message = exception?.Message;
                
                dataAccess.SetData(index, message);

                if(!string.IsNullOrWhiteSpace(message))
                {
                    AddRuntimeMessage(GH_RuntimeMessageLevel.Error, message);
                    return;
                }
            }

            index = Params.IndexOfOutputParam("Outputs");
            if (index != -1)
            {
                List<GooOutput>? gooOutputs = null;
                if(response?.Outputs is IEnumerable<Output> outputs)
                {
                    gooOutputs = [];
                    foreach(Output output in outputs)
                    {
                        SerializableOutput? serializableOutput = null;
                        try
                        {
                            serializableOutput = new SerializableOutput(output.Name, output?.Value as dynamic);
                        }
                        catch(Exception exception_Conversion)
                        {
                            AddRuntimeMessage(GH_RuntimeMessageLevel.Error, string.Format("Could convert output: {0}", exception_Conversion.Message));
                            return;
                        }

                        gooOutputs.Add(new GooOutput(serializableOutput));
                    }

                }

                dataAccess.SetDataList(index, gooOutputs);
            }
        }
    }
}
