using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistributionTenant
{
    [JsiiByValue(fqn: "aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizations")]
    public class CloudfrontDistributionTenantCustomizations : aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizations
    {
        private object? _certificate;

        /// <summary>certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#certificate CloudfrontDistributionTenant#certificate}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Certificate
        {
            get => _certificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _certificate = value;
            }
        }

        private object? _geoRestriction;

        /// <summary>geo_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#geo_restriction CloudfrontDistributionTenant#geo_restriction}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsGeoRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GeoRestriction
        {
            get => _geoRestriction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsGeoRestriction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsGeoRestriction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _geoRestriction = value;
            }
        }

        private object? _webAcl;

        /// <summary>web_acl block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_distribution_tenant#web_acl CloudfrontDistributionTenant#web_acl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webAcl", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistributionTenant.CloudfrontDistributionTenantCustomizationsWebAcl\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? WebAcl
        {
            get => _webAcl;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsWebAcl[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontDistributionTenant.ICloudfrontDistributionTenantCustomizationsWebAcl).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _webAcl = value;
            }
        }
    }
}
