using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplication
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceApplication.DataintegrationWorkspaceApplicationSourceApplicationInfo")]
    public class DataintegrationWorkspaceApplicationSourceApplicationInfo : oci.DataintegrationWorkspaceApplication.IDataintegrationWorkspaceApplicationSourceApplicationInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application#application_key DataintegrationWorkspaceApplication#application_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application#copy_type DataintegrationWorkspaceApplication#copy_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CopyType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application#workspace_id DataintegrationWorkspaceApplication#workspace_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WorkspaceId
        {
            get;
            set;
        }
    }
}
