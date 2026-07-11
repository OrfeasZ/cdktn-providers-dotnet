using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.WorkitemtrackingprocessControl
{
    [JsiiByValue(fqn: "azuredevops.workitemtrackingprocessControl.WorkitemtrackingprocessControlTimeouts")]
    public class WorkitemtrackingprocessControlTimeouts : azuredevops.WorkitemtrackingprocessControl.IWorkitemtrackingprocessControlTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#create WorkitemtrackingprocessControl#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#delete WorkitemtrackingprocessControl#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#read WorkitemtrackingprocessControl#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/workitemtrackingprocess_control#update WorkitemtrackingprocessControl#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
