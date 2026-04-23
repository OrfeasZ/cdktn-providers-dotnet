using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictionsGeoRestriction")]
    public class CloudfrontMultitenantDistributionRestrictionsGeoRestriction : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionRestrictionsGeoRestriction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#restriction_type CloudfrontMultitenantDistribution#restriction_type}.</summary>
        [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}")]
        public string RestrictionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#items CloudfrontMultitenantDistribution#items}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Items
        {
            get;
            set;
        }
    }
}
