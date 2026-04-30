using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginVpcOriginConfig")]
    public class CloudfrontMultitenantDistributionOriginVpcOriginConfig : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginVpcOriginConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#vpc_origin_id CloudfrontMultitenantDistribution#vpc_origin_id}.</summary>
        [JsiiProperty(name: "vpcOriginId", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcOriginId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_keepalive_timeout CloudfrontMultitenantDistribution#origin_keepalive_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OriginKeepaliveTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_read_timeout CloudfrontMultitenantDistribution#origin_read_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? OriginReadTimeout
        {
            get;
            set;
        }
    }
}
