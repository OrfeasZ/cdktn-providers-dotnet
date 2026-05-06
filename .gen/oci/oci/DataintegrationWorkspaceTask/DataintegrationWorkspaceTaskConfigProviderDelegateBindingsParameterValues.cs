using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegateBindingsParameterValues")]
    public class DataintegrationWorkspaceTaskConfigProviderDelegateBindingsParameterValues : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegateBindingsParameterValues
    {
        /// <summary>root_object_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#root_object_value DataintegrationWorkspaceTask#root_object_value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rootObjectValue", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskConfigProviderDelegateBindingsParameterValuesRootObjectValue\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskConfigProviderDelegateBindingsParameterValuesRootObjectValue? RootObjectValue
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#simple_value DataintegrationWorkspaceTask#simple_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "simpleValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SimpleValue
        {
            get;
            set;
        }
    }
}
