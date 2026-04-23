using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiByValue(fqn: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsCertificate")]
    public class CloudfrontDistributionTenantCustomizationsCertificate : aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#arn CloudfrontDistributionTenant#arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Arn
        {
            get;
            set;
        }
    }
}
