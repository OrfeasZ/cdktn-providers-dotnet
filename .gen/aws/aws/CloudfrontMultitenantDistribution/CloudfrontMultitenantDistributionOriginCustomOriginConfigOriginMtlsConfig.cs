using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig")]
    public class CloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginCustomOriginConfigOriginMtlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/cloudfront_multitenant_distribution#client_certificate_arn CloudfrontMultitenantDistribution#client_certificate_arn}.</summary>
        [JsiiProperty(name: "clientCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientCertificateArn
        {
            get;
            set;
        }
    }
}
