using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsVault
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.kmsVault.KmsVaultRestoreFromFile")]
    public class KmsVaultRestoreFromFile : oci.KmsVault.IKmsVaultRestoreFromFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#content_length KmsVault#content_length}.</summary>
        [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#restore_vault_from_file_details KmsVault#restore_vault_from_file_details}.</summary>
        [JsiiProperty(name: "restoreVaultFromFileDetails", typeJson: "{\"primitive\":\"string\"}")]
        public string RestoreVaultFromFileDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_vault#content_md5 KmsVault#content_md5}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentMd5", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentMd5
        {
            get;
            set;
        }
    }
}
