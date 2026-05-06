using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayload")]
    public class DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayload : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parameter_value DataintegrationWorkspaceTask#parameter_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameterValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterValue
        {
            get;
            set;
        }

        /// <summary>ref_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#ref_value DataintegrationWorkspaceTask#ref_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "refValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValue? RefValue
        {
            get;
            set;
        }
    }
}
