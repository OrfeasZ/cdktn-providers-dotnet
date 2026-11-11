using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationBlueprint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockdataautomationBlueprint.BedrockdataautomationBlueprintEncryptionConfiguration")]
    public class BedrockdataautomationBlueprintEncryptionConfiguration : aws.BedrockdataautomationBlueprint.IBedrockdataautomationBlueprintEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_blueprint#kms_key_id BedrockdataautomationBlueprint#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_blueprint#kms_encryption_context BedrockdataautomationBlueprint#kms_encryption_context}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsEncryptionContext", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? KmsEncryptionContext
        {
            get;
            set;
        }
    }
}
