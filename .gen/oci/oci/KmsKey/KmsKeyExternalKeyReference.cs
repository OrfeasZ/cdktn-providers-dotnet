using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.KmsKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.kmsKey.KmsKeyExternalKeyReference")]
    public class KmsKeyExternalKeyReference : oci.KmsKey.IKmsKeyExternalKeyReference
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/kms_key#external_key_id KmsKey#external_key_id}.</summary>
        [JsiiProperty(name: "externalKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalKeyId
        {
            get;
            set;
        }
    }
}
