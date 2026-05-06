using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceExportRequest
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceExportRequest.DataintegrationWorkspaceExportRequestTimeouts")]
    public class DataintegrationWorkspaceExportRequestTimeouts : oci.DataintegrationWorkspaceExportRequest.IDataintegrationWorkspaceExportRequestTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_export_request#create DataintegrationWorkspaceExportRequest#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_export_request#delete DataintegrationWorkspaceExportRequest#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_export_request#update DataintegrationWorkspaceExportRequest#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
