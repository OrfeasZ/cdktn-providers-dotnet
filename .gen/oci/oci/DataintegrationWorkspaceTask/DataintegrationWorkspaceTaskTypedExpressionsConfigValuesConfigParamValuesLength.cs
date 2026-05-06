using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValuesLength")]
    public class DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValuesLength : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValuesLength
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#int_value DataintegrationWorkspaceTask#int_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intValue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntValue
        {
            get;
            set;
        }
    }
}
