using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationBlueprint")]
    public class BedrockdataautomationProjectCustomOutputConfigurationBlueprint : aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationBlueprint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_arn BedrockdataautomationProject#blueprint_arn}.</summary>
        [JsiiProperty(name: "blueprintArn", typeJson: "{\"primitive\":\"string\"}")]
        public string BlueprintArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_stage BedrockdataautomationProject#blueprint_stage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blueprintStage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlueprintStage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#blueprint_version BedrockdataautomationProject#blueprint_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "blueprintVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BlueprintVersion
        {
            get;
            set;
        }
    }
}
