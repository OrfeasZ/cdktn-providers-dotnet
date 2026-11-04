using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfigurationPiiEntitiesConfiguration")]
    public class BedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfigurationPiiEntitiesConfiguration : aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfigurationPiiEntitiesConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#pii_entity_types BedrockdataautomationProject#pii_entity_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "piiEntityTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PiiEntityTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#redaction_mask_mode BedrockdataautomationProject#redaction_mask_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redactionMaskMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedactionMaskMode
        {
            get;
            set;
        }
    }
}
