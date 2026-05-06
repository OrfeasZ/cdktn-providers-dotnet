using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceImportRequest
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceImportRequestImportConflictResolution), fullyQualifiedName: "oci.dataintegrationWorkspaceImportRequest.DataintegrationWorkspaceImportRequestImportConflictResolution")]
    public interface IDataintegrationWorkspaceImportRequestImportConflictResolution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#import_conflict_resolution_type DataintegrationWorkspaceImportRequest#import_conflict_resolution_type}.</summary>
        [JsiiProperty(name: "importConflictResolutionType", typeJson: "{\"primitive\":\"string\"}")]
        string ImportConflictResolutionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#duplicate_prefix DataintegrationWorkspaceImportRequest#duplicate_prefix}.</summary>
        [JsiiProperty(name: "duplicatePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DuplicatePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#duplicate_suffix DataintegrationWorkspaceImportRequest#duplicate_suffix}.</summary>
        [JsiiProperty(name: "duplicateSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DuplicateSuffix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceImportRequestImportConflictResolution), fullyQualifiedName: "oci.dataintegrationWorkspaceImportRequest.DataintegrationWorkspaceImportRequestImportConflictResolution")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceImportRequest.IDataintegrationWorkspaceImportRequestImportConflictResolution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#import_conflict_resolution_type DataintegrationWorkspaceImportRequest#import_conflict_resolution_type}.</summary>
            [JsiiProperty(name: "importConflictResolutionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ImportConflictResolutionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#duplicate_prefix DataintegrationWorkspaceImportRequest#duplicate_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duplicatePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DuplicatePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_import_request#duplicate_suffix DataintegrationWorkspaceImportRequest#duplicate_suffix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duplicateSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DuplicateSuffix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
