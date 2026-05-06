using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceImportRequest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceImportRequest.DataintegrationWorkspaceImportRequestImportConflictResolution")]
    public class DataintegrationWorkspaceImportRequestImportConflictResolution : oci.DataintegrationWorkspaceImportRequest.IDataintegrationWorkspaceImportRequestImportConflictResolution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#import_conflict_resolution_type DataintegrationWorkspaceImportRequest#import_conflict_resolution_type}.</summary>
        [JsiiProperty(name: "importConflictResolutionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ImportConflictResolutionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#duplicate_prefix DataintegrationWorkspaceImportRequest#duplicate_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duplicatePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DuplicatePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#duplicate_suffix DataintegrationWorkspaceImportRequest#duplicate_suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duplicateSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DuplicateSuffix
        {
            get;
            set;
        }
    }
}
