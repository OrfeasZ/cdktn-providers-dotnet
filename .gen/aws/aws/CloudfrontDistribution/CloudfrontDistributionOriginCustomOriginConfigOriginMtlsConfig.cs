using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontDistribution.CloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig")]
    public class CloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig : aws.CloudfrontDistribution.ICloudfrontDistributionOriginCustomOriginConfigOriginMtlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/cloudfront_distribution#client_certificate_arn CloudfrontDistribution#client_certificate_arn}.</summary>
        [JsiiProperty(name: "clientCertificateArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientCertificateArn
        {
            get;
            set;
        }
    }
}
