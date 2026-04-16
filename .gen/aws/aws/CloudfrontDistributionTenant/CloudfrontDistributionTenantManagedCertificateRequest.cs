using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiByValue(fqn: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantManagedCertificateRequest")]
    public class CloudfrontDistributionTenantManagedCertificateRequest : aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantManagedCertificateRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution_tenant#certificate_transparency_logging_preference CloudfrontDistributionTenant#certificate_transparency_logging_preference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateTransparencyLoggingPreference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution_tenant#primary_domain_name CloudfrontDistributionTenant#primary_domain_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "primaryDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrimaryDomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution_tenant#validation_token_host CloudfrontDistributionTenant#validation_token_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "validationTokenHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValidationTokenHost
        {
            get;
            set;
        }
    }
}
