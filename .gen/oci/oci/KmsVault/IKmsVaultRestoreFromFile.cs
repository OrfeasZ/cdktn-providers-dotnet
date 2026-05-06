using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    [JsiiInterface(nativeType: typeof(IKmsVaultRestoreFromFile), fullyQualifiedName: "oci.kmsVault.KmsVaultRestoreFromFile")]
    public interface IKmsVaultRestoreFromFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#content_length KmsVault#content_length}.</summary>
        [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
        string ContentLength
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#restore_vault_from_file_details KmsVault#restore_vault_from_file_details}.</summary>
        [JsiiProperty(name: "restoreVaultFromFileDetails", typeJson: "{\"primitive\":\"string\"}")]
        string RestoreVaultFromFileDetails
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#content_md5 KmsVault#content_md5}.</summary>
        [JsiiProperty(name: "contentMd5", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ContentMd5
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKmsVaultRestoreFromFile), fullyQualifiedName: "oci.kmsVault.KmsVaultRestoreFromFile")]
        internal sealed class _Proxy : DeputyBase, oci.KmsVault.IKmsVaultRestoreFromFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#content_length KmsVault#content_length}.</summary>
            [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
            public string ContentLength
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#restore_vault_from_file_details KmsVault#restore_vault_from_file_details}.</summary>
            [JsiiProperty(name: "restoreVaultFromFileDetails", typeJson: "{\"primitive\":\"string\"}")]
            public string RestoreVaultFromFileDetails
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#content_md5 KmsVault#content_md5}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "contentMd5", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ContentMd5
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
