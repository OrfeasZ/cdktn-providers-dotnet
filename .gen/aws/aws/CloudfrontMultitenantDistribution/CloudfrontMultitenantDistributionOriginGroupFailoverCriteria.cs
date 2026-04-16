using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupFailoverCriteria")]
    public class CloudfrontMultitenantDistributionOriginGroupFailoverCriteria : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginGroupFailoverCriteria
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#status_codes CloudfrontMultitenantDistribution#status_codes}.</summary>
        [JsiiProperty(name: "statusCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] StatusCodes
        {
            get;
            set;
        }
    }
}
