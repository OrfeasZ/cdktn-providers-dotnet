using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontDistribution.CloudfrontDistributionViewerMtlsConfigTrustStoreConfig")]
    public class CloudfrontDistributionViewerMtlsConfigTrustStoreConfig : aws.CloudfrontDistribution.ICloudfrontDistributionViewerMtlsConfigTrustStoreConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution#trust_store_id CloudfrontDistribution#trust_store_id}.</summary>
        [JsiiProperty(name: "trustStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public string TrustStoreId
        {
            get;
            set;
        }

        private object? _advertiseTrustStoreCaNames;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution#advertise_trust_store_ca_names CloudfrontDistribution#advertise_trust_store_ca_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "advertiseTrustStoreCaNames", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AdvertiseTrustStoreCaNames
        {
            get => _advertiseTrustStoreCaNames;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _advertiseTrustStoreCaNames = value;
            }
        }

        private object? _ignoreCertificateExpiry;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_distribution#ignore_certificate_expiry CloudfrontDistribution#ignore_certificate_expiry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ignoreCertificateExpiry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IgnoreCertificateExpiry
        {
            get => _ignoreCertificateExpiry;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ignoreCertificateExpiry = value;
            }
        }
    }
}
