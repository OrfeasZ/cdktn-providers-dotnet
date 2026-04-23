using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontTrustStore
{
    [JsiiByValue(fqn: "aws.cloudfrontTrustStore.CloudfrontTrustStoreCaCertificatesBundleSource")]
    public class CloudfrontTrustStoreCaCertificatesBundleSource : aws.CloudfrontTrustStore.ICloudfrontTrustStoreCaCertificatesBundleSource
    {
        private object? _caCertificatesBundleS3Location;

        /// <summary>ca_certificates_bundle_s3_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_trust_store#ca_certificates_bundle_s3_location CloudfrontTrustStore#ca_certificates_bundle_s3_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "caCertificatesBundleS3Location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontTrustStore.CloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CaCertificatesBundleS3Location
        {
            get => _caCertificatesBundleS3Location;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontTrustStore.ICloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.CloudfrontTrustStore.ICloudfrontTrustStoreCaCertificatesBundleSourceCaCertificatesBundleS3Location).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _caCertificatesBundleS3Location = value;
            }
        }
    }
}
