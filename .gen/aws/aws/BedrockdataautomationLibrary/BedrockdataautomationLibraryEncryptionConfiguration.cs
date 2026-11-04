using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationLibrary
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockdataautomationLibrary.BedrockdataautomationLibraryEncryptionConfiguration")]
    public class BedrockdataautomationLibraryEncryptionConfiguration : aws.BedrockdataautomationLibrary.IBedrockdataautomationLibraryEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_library#kms_key_id BedrockdataautomationLibrary#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_library#kms_encryption_context BedrockdataautomationLibrary#kms_encryption_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsEncryptionContext", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? KmsEncryptionContext
        {
            get;
            set;
        }
    }
}
