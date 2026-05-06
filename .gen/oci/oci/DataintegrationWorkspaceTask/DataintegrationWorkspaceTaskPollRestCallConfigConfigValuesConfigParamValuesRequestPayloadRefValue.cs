using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue")]
    public class DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue
    {
        /// <summary>config_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_values DataintegrationWorkspaceTask#config_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues? ConfigValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#key DataintegrationWorkspaceTask#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#model_type DataintegrationWorkspaceTask#model_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#name DataintegrationWorkspaceTask#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
