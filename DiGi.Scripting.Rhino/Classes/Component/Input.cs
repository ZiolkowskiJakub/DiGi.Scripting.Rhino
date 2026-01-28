using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Scripting.Rhino.Classes
{
    public class Input : VariableParameterComponent
    {
        /// <summary>
        /// Initializes a new instance of object.
        /// </summary>
        public Input()
          : base("Scripting.Input", "Scripting.Input",
              "Create Input",
              "DiGi", "DiGi.Scripting")
        {
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("5b7fed7d-3106-4ea2-994f-c33aed73c3cc");

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
                    new Param(new GooObjectParam() { Name = "Value", NickName = "Value", Description = "Value", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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
                    new Param(new GooInputParam() { Name = "Input", NickName = "Input", Description = "Input", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
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

            index = Params.IndexOfInputParam("Value");
            object? value = null;
            if (index == -1 || !dataAccess.GetData(index, ref value))
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

            if (DiGi.Rhino.Core.Query.TryGetValue(value, out object? @value_Converted))
            {
                value = value_Converted;
            }

            if (type != null)
            {
                if (DiGi.Core.Query.TryConvert(value, out value_Converted, type))
                {
                    value = value_Converted;
                }
            }

            Scripting.Classes.SerializableInput serializableInput = new(name, value as dynamic);

            index = Params.IndexOfOutputParam("Input");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooInput(serializableInput));
            }
        }
    }
}