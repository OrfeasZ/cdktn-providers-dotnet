using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigCsv")]
    public class CloudwatchLogTransformerTransformerConfigCsv : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigCsv
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#columns CloudwatchLogTransformer#columns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Columns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#delimiter CloudwatchLogTransformer#delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#quote_character CloudwatchLogTransformer#quote_character}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "quoteCharacter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QuoteCharacter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }
    }
}
