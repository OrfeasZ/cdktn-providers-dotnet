using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues")]
    public class DataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValues
    {
        /// <summary>config_param_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_param_values DataintegrationWorkspaceTask#config_param_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configParamValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskCancelRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues? ConfigParamValues
        {
            get;
            set;
        }
    }
}
