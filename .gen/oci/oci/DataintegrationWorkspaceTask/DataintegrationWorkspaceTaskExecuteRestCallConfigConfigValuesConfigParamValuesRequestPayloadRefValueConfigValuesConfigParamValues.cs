using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues")]
    public class DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValues
    {
        /// <summary>data_param block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#data_param DataintegrationWorkspaceTask#data_param}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataParam", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValuesDataParam\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskExecuteRestCallConfigConfigValuesConfigParamValuesRequestPayloadRefValueConfigValuesConfigParamValuesDataParam? DataParam
        {
            get;
            set;
        }
    }
}
