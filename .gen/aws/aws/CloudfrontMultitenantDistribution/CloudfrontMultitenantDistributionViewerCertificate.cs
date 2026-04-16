using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiByValue(fqn: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionViewerCertificate")]
    public class CloudfrontMultitenantDistributionViewerCertificate : aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionViewerCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#acm_certificate_arn CloudfrontMultitenantDistribution#acm_certificate_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acmCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AcmCertificateArn
        {
            get;
            set;
        }

        private object? _cloudfrontDefaultCertificate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#cloudfront_default_certificate CloudfrontMultitenantDistribution#cloudfront_default_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudfrontDefaultCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CloudfrontDefaultCertificate
        {
            get => _cloudfrontDefaultCertificate;
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
                _cloudfrontDefaultCertificate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#minimum_protocol_version CloudfrontMultitenantDistribution#minimum_protocol_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumProtocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinimumProtocolVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudfront_multitenant_distribution#ssl_support_method CloudfrontMultitenantDistribution#ssl_support_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslSupportMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SslSupportMethod
        {
            get;
            set;
        }
    }
}
