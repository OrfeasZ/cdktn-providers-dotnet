using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValues")]
    public class DataintegrationWorkspaceTaskTypedExpressionsConfigValues : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValues
    {
        /// <summary>config_param_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#config_param_values DataintegrationWorkspaceTask#config_param_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configParamValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesConfigParamValues? ConfigParamValues
        {
            get;
            set;
        }

        /// <summary>parent_ref block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parent_ref DataintegrationWorkspaceTask#parent_ref}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskTypedExpressionsConfigValuesParentRef\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskTypedExpressionsConfigValuesParentRef? ParentRef
        {
            get;
            set;
        }
    }
}
