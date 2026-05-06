using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageMountTarget
{
    [JsiiInterface(nativeType: typeof(IFileStorageMountTargetKerberos), fullyQualifiedName: "oci.fileStorageMountTarget.FileStorageMountTargetKerberos")]
    public interface IFileStorageMountTargetKerberos
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#kerberos_realm FileStorageMountTarget#kerberos_realm}.</summary>
        [JsiiProperty(name: "kerberosRealm", typeJson: "{\"primitive\":\"string\"}")]
        string KerberosRealm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#backup_key_tab_secret_version FileStorageMountTarget#backup_key_tab_secret_version}.</summary>
        [JsiiProperty(name: "backupKeyTabSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupKeyTabSecretVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#current_key_tab_secret_version FileStorageMountTarget#current_key_tab_secret_version}.</summary>
        [JsiiProperty(name: "currentKeyTabSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CurrentKeyTabSecretVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#is_kerberos_enabled FileStorageMountTarget#is_kerberos_enabled}.</summary>
        [JsiiProperty(name: "isKerberosEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsKerberosEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#key_tab_secret_id FileStorageMountTarget#key_tab_secret_id}.</summary>
        [JsiiProperty(name: "keyTabSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyTabSecretId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFileStorageMountTargetKerberos), fullyQualifiedName: "oci.fileStorageMountTarget.FileStorageMountTargetKerberos")]
        internal sealed class _Proxy : DeputyBase, oci.FileStorageMountTarget.IFileStorageMountTargetKerberos
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#kerberos_realm FileStorageMountTarget#kerberos_realm}.</summary>
            [JsiiProperty(name: "kerberosRealm", typeJson: "{\"primitive\":\"string\"}")]
            public string KerberosRealm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#backup_key_tab_secret_version FileStorageMountTarget#backup_key_tab_secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupKeyTabSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupKeyTabSecretVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#current_key_tab_secret_version FileStorageMountTarget#current_key_tab_secret_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "currentKeyTabSecretVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CurrentKeyTabSecretVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#is_kerberos_enabled FileStorageMountTarget#is_kerberos_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isKerberosEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsKerberosEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/file_storage_mount_target#key_tab_secret_id FileStorageMountTarget#key_tab_secret_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyTabSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyTabSecretId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
