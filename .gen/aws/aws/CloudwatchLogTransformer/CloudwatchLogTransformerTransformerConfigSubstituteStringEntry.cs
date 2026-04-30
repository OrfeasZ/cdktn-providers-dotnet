using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigSubstituteStringEntry")]
    public class CloudwatchLogTransformerTransformerConfigSubstituteStringEntry : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigSubstituteStringEntry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#from CloudwatchLogTransformer#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
        public string From
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#source CloudwatchLogTransformer#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public string Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_log_transformer#to CloudwatchLogTransformer#to}.</summary>
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}")]
        public string To
        {
            get;
            set;
        }
    }
}
