using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCustomErrorResponse")]
    public class CloudfrontMultitenantDistributionCustomErrorResponse : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCustomErrorResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#error_code CloudfrontMultitenantDistribution#error_code}.</summary>
        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}")]
        public double ErrorCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#error_caching_min_ttl CloudfrontMultitenantDistribution#error_caching_min_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ErrorCachingMinTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#response_code CloudfrontMultitenantDistribution#response_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#response_page_path CloudfrontMultitenantDistribution#response_page_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponsePagePath
        {
            get;
            set;
        }
    }
}
