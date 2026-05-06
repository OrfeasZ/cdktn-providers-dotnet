using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageExport
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageExport.FileStorageExportExportOptions")]
    public class FileStorageExportExportOptions : oci.FileStorageExport.IFileStorageExportExportOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#source FileStorageExport#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#access FileStorageExport#access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Access
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#allowed_auth FileStorageExport#allowed_auth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedAuth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowedAuth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#anonymous_gid FileStorageExport#anonymous_gid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "anonymousGid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AnonymousGid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#anonymous_uid FileStorageExport#anonymous_uid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "anonymousUid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AnonymousUid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#identity_squash FileStorageExport#identity_squash}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identitySquash", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentitySquash
        {
            get;
            set;
        }

        private object? _isAnonymousAccessAllowed;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#is_anonymous_access_allowed FileStorageExport#is_anonymous_access_allowed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isAnonymousAccessAllowed", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsAnonymousAccessAllowed
        {
            get => _isAnonymousAccessAllowed;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isAnonymousAccessAllowed = value;
            }
        }

        private object? _requirePrivilegedSourcePort;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_export#require_privileged_source_port FileStorageExport#require_privileged_source_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requirePrivilegedSourcePort", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RequirePrivilegedSourcePort
        {
            get => _requirePrivilegedSourcePort;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requirePrivilegedSourcePort = value;
            }
        }
    }
}
