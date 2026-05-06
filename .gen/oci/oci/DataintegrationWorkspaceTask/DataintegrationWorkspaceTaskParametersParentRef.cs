using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceTask
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceTask.DataintegrationWorkspaceTaskParametersParentRef")]
    public class DataintegrationWorkspaceTaskParametersParentRef : oci.DataintegrationWorkspaceTask.IDataintegrationWorkspaceTaskParametersParentRef
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#parent DataintegrationWorkspaceTask#parent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Parent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_task#root_doc_id DataintegrationWorkspaceTask#root_doc_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rootDocId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RootDocId
        {
            get;
            set;
        }
    }
}
