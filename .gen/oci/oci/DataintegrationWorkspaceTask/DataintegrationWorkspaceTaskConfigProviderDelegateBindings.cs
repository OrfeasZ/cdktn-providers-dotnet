using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegateBindings")]
    public class DataintegrationWorkspaceTaskConfigProviderDelegateBindings : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegateBindings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#key DataintegrationWorkspaceTask#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>parameter_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parameter_values DataintegrationWorkspaceTask#parameter_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameterValues", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegateBindingsParameterValues\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegateBindingsParameterValues? ParameterValues
        {
            get;
            set;
        }
    }
}
