using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreGatewayTarget
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreGatewayTarget.BedrockagentcoreGatewayTargetTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems")]
    public class BedrockagentcoreGatewayTargetTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems : aws.BedrockagentcoreGatewayTarget.IBedrockagentcoreGatewayTargetTargetConfigurationMcpLambdaToolSchemaInlinePayloadInputSchemaPropertyItemsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#type BedrockagentcoreGatewayTarget#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#description BedrockagentcoreGatewayTarget#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#items_json BedrockagentcoreGatewayTarget#items_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "itemsJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ItemsJson
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/bedrockagentcore_gateway_target#properties_json BedrockagentcoreGatewayTarget#properties_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "propertiesJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PropertiesJson
        {
            get;
            set;
        }
    }
}
