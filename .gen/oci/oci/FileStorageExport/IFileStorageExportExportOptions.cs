using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageExport
{
    [JsiiInterface(nativeType: typeof(IFileStorageExportExportOptions), fullyQualifiedName: "oci.fileStorageExport.FileStorageExportExportOptions")]
    public interface IFileStorageExportExportOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#source FileStorageExport#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#access FileStorageExport#access}.</summary>
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Access
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#allowed_auth FileStorageExport#allowed_auth}.</summary>
        [JsiiProperty(name: "allowedAuth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#anonymous_gid FileStorageExport#anonymous_gid}.</summary>
        [JsiiProperty(name: "anonymousGid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AnonymousGid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#anonymous_uid FileStorageExport#anonymous_uid}.</summary>
        [JsiiProperty(name: "anonymousUid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AnonymousUid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#identity_squash FileStorageExport#identity_squash}.</summary>
        [JsiiProperty(name: "identitySquash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentitySquash
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#is_anonymous_access_allowed FileStorageExport#is_anonymous_access_allowed}.</summary>
        [JsiiProperty(name: "isAnonymousAccessAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsAnonymousAccessAllowed
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#require_privileged_source_port FileStorageExport#require_privileged_source_port}.</summary>
        [JsiiProperty(name: "requirePrivilegedSourcePort", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequirePrivilegedSourcePort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFileStorageExportExportOptions), fullyQualifiedName: "oci.fileStorageExport.FileStorageExportExportOptions")]
        internal sealed class _Proxy : DeputyBase, oci.FileStorageExport.IFileStorageExportExportOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#source FileStorageExport#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#access FileStorageExport#access}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Access
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#allowed_auth FileStorageExport#allowed_auth}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAuth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAuth
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#anonymous_gid FileStorageExport#anonymous_gid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "anonymousGid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AnonymousGid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#anonymous_uid FileStorageExport#anonymous_uid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "anonymousUid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AnonymousUid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#identity_squash FileStorageExport#identity_squash}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identitySquash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentitySquash
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#is_anonymous_access_allowed FileStorageExport#is_anonymous_access_allowed}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isAnonymousAccessAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsAnonymousAccessAllowed
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#require_privileged_source_port FileStorageExport#require_privileged_source_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "requirePrivilegedSourcePort", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequirePrivilegedSourcePort
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
