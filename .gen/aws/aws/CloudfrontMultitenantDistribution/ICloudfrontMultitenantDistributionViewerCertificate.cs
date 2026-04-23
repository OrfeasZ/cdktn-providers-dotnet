using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionViewerCertificate), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionViewerCertificate")]
    public interface ICloudfrontMultitenantDistributionViewerCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#acm_certificate_arn CloudfrontMultitenantDistribution#acm_certificate_arn}.</summary>
        [JsiiProperty(name: "acmCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AcmCertificateArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#cloudfront_default_certificate CloudfrontMultitenantDistribution#cloudfront_default_certificate}.</summary>
        [JsiiProperty(name: "cloudfrontDefaultCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudfrontDefaultCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#minimum_protocol_version CloudfrontMultitenantDistribution#minimum_protocol_version}.</summary>
        [JsiiProperty(name: "minimumProtocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinimumProtocolVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#ssl_support_method CloudfrontMultitenantDistribution#ssl_support_method}.</summary>
        [JsiiProperty(name: "sslSupportMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SslSupportMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionViewerCertificate), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionViewerCertificate")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionViewerCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#acm_certificate_arn CloudfrontMultitenantDistribution#acm_certificate_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "acmCertificateArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AcmCertificateArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#cloudfront_default_certificate CloudfrontMultitenantDistribution#cloudfront_default_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudfrontDefaultCertificate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CloudfrontDefaultCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#minimum_protocol_version CloudfrontMultitenantDistribution#minimum_protocol_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minimumProtocolVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinimumProtocolVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#ssl_support_method CloudfrontMultitenantDistribution#ssl_support_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslSupportMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SslSupportMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
