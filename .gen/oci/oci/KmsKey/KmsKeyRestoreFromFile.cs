using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.kmsKey.KmsKeyRestoreFromFile")]
    public class KmsKeyRestoreFromFile : oci.KmsKey.IKmsKeyRestoreFromFile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#content_length KmsKey#content_length}.</summary>
        [JsiiProperty(name: "contentLength", typeJson: "{\"primitive\":\"string\"}")]
        public string ContentLength
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#restore_key_from_file_details KmsKey#restore_key_from_file_details}.</summary>
        [JsiiProperty(name: "restoreKeyFromFileDetails", typeJson: "{\"primitive\":\"string\"}")]
        public string RestoreKeyFromFileDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#content_md5 KmsKey#content_md5}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contentMd5", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContentMd5
        {
            get;
            set;
        }
    }
}
