using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionTenantManagedCertificateRequest), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantManagedCertificateRequest")]
    public interface ICloudfrontDistributionTenantManagedCertificateRequest
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#certificate_transparency_logging_preference CloudfrontDistributionTenant#certificate_transparency_logging_preference}.</summary>
        [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateTransparencyLoggingPreference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#primary_domain_name CloudfrontDistributionTenant#primary_domain_name}.</summary>
        [JsiiProperty(name: "primaryDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrimaryDomainName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#validation_token_host CloudfrontDistributionTenant#validation_token_host}.</summary>
        [JsiiProperty(name: "validationTokenHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidationTokenHost
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionTenantManagedCertificateRequest), fullyQualifiedName: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantManagedCertificateRequest")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantManagedCertificateRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#certificate_transparency_logging_preference CloudfrontDistributionTenant#certificate_transparency_logging_preference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateTransparencyLoggingPreference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateTransparencyLoggingPreference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#primary_domain_name CloudfrontDistributionTenant#primary_domain_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "primaryDomainName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrimaryDomainName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution_tenant#validation_token_host CloudfrontDistributionTenant#validation_token_host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validationTokenHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidationTokenHost
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
