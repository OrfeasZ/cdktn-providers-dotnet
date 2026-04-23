using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionDefaultCacheBehaviorAllowedMethods")]
    public class CloudfrontMultitenantDistributionDefaultCacheBehaviorAllowedMethods : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionDefaultCacheBehaviorAllowedMethods
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#cached_methods CloudfrontMultitenantDistribution#cached_methods}.</summary>
        [JsiiProperty(name: "cachedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CachedMethods
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#items CloudfrontMultitenantDistribution#items}.</summary>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Items
        {
            get;
            set;
        }
    }
}
