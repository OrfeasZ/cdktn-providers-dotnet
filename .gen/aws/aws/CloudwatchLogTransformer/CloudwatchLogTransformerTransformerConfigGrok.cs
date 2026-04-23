using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigGrok")]
    public class CloudwatchLogTransformerTransformerConfigGrok : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigGrok
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#match CloudwatchLogTransformer#match}.</summary>
        [JsiiProperty(name: "match", typeJson: "{\"primitive\":\"string\"}")]
        public string Match
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
