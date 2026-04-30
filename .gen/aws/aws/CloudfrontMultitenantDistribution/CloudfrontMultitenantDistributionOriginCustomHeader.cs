using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomHeader")]
    public class CloudfrontMultitenantDistributionOriginCustomHeader : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#header_name CloudfrontMultitenantDistribution#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#header_value CloudfrontMultitenantDistribution#header_value}.</summary>
        [JsiiProperty(name: "headerValue", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderValue
        {
            get;
            set;
        }
    }
}
