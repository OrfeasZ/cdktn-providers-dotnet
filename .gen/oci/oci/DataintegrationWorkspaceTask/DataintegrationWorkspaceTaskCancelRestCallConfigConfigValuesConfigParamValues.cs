using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValues")]
    public class DataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValues : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValues
    {
        /// <summary>request_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#request_payload DataintegrationWorkspaceTask#request_payload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestPayload", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestPayload\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestPayload? RequestPayload
        {
            get;
            set;
        }

        /// <summary>request_url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#request_url DataintegrationWorkspaceTask#request_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestUrl", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestUrl\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestUrl? RequestUrl
        {
            get;
            set;
        }
    }
}
