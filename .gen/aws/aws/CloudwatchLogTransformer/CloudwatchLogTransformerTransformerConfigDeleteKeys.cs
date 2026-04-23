using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchLogTransformer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudwatchLogTransformer.CloudwatchLogTransformerTransformerConfigDeleteKeys")]
    public class CloudwatchLogTransformerTransformerConfigDeleteKeys : aws.CloudwatchLogTransformer.ICloudwatchLogTransformerTransformerConfigDeleteKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudwatch_log_transformer#with_keys CloudwatchLogTransformer#with_keys}.</summary>
        [JsiiProperty(name: "withKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] WithKeys
        {
            get;
            set;
        }
    }
}
