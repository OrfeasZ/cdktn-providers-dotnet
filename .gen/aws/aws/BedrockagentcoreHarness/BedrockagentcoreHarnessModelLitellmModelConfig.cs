using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessModelLitellmModelConfig")]
    public class BedrockagentcoreHarnessModelLitellmModelConfig : aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessModelLitellmModelConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#model_id BedrockagentcoreHarness#model_id}.</summary>
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}")]
        public string ModelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#additional_params BedrockagentcoreHarness#additional_params}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalParams", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdditionalParams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#api_base BedrockagentcoreHarness#api_base}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "apiBase", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiBase
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#api_key_arn BedrockagentcoreHarness#api_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "apiKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiKeyArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#max_tokens BedrockagentcoreHarness#max_tokens}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTokens", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTokens
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#temperature BedrockagentcoreHarness#temperature}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "temperature", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Temperature
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/bedrockagentcore_harness#top_p BedrockagentcoreHarness#top_p}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topP", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TopP
        {
            get;
            set;
        }
    }
}
