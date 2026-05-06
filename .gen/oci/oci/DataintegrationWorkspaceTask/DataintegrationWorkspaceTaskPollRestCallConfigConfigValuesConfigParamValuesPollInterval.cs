using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollInterval")]
    public class DataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollInterval : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskPollRestCallConfigConfigValuesConfigParamValuesPollInterval
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#object_value DataintegrationWorkspaceTask#object_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ObjectValue
        {
            get;
            set;
        }
    }
}
