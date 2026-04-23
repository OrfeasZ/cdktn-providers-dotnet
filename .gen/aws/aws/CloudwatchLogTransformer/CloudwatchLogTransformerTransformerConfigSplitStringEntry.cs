using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSplitStringEntry")]
    public class CloudwatchLogTransformerTransformerConfigSplitStringEntry : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigSplitStringEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#delimiter CloudwatchLogTransformer#delimiter}.</summary>
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}")]
        public string Delimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }
    }
}
