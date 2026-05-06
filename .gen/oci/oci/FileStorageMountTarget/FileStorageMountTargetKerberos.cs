using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageMountTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.fileStorageMountTarget.FileStorageMountTargetKerberos")]
    public class FileStorageMountTargetKerberos : oci.FileStorageMountTarget.IFileStorageMountTargetKerberos
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#kerberos_realm FileStorageMountTarget#kerberos_realm}.</summary>
        [JsiiProperty(name: "kerberosRealm", typeJson: "{\"primitive\":\"string\"}")]
        public string KerberosRealm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#backup_key_tab_secret_version FileStorageMountTarget#backup_key_tab_secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupKeyTabSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupKeyTabSecretVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#current_key_tab_secret_version FileStorageMountTarget#current_key_tab_secret_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "currentKeyTabSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CurrentKeyTabSecretVersion
        {
            get;
            set;
        }

        private object? _isKerberosEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#is_kerberos_enabled FileStorageMountTarget#is_kerberos_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isKerberosEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsKerberosEnabled
        {
            get => _isKerberosEnabled;
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
                _isKerberosEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#key_tab_secret_id FileStorageMountTarget#key_tab_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyTabSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyTabSecretId
        {
            get;
            set;
        }
    }
}
