using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorFunctionAssociation")]
    public class CloudfrontMultitenantDistributionDefaultCacheBehaviorFunctionAssociation : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionDefaultCacheBehaviorFunctionAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#event_type CloudfrontMultitenantDistribution#event_type}.</summary>
        [JsiiProperty(name: "eventType", typeJson: "{\"primitive\":\"string\"}")]
        public string EventType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#function_arn CloudfrontMultitenantDistribution#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionArn
        {
            get;
            set;
        }
    }
}
