using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantDomain")]
    public class CloudfrontDistributionTenantDomain : aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantDomain
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#domain CloudfrontDistributionTenant#domain}.</summary>
        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public string Domain
        {
            get;
            set;
        }
    }
}
