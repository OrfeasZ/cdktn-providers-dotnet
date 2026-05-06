using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues")]
    public class DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues
    {
        /// <summary>length block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#length DataintegrationWorkspaceTask#length}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "length", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValuesLength\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValuesLength? Length
        {
            get;
            set;
        }

        /// <summary>scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#scale DataintegrationWorkspaceTask#scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scale", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValuesScale\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValuesScale? Scale
        {
            get;
            set;
        }
    }
}
