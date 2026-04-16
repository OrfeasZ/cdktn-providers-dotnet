using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigParseJson")]
    public class CloudwatchLogTransformerTransformerConfigParseJson : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigParseJson
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#destination CloudwatchLogTransformer#destination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Destination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }
    }
}
