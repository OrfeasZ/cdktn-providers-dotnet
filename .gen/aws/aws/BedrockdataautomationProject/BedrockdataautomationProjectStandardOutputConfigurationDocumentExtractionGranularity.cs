using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionGranularity")]
    public class BedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionGranularity : aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionGranularity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#types BedrockdataautomationProject#types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "types", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Types
        {
            get;
            set;
        }
    }
}
