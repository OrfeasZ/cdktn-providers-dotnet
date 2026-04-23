using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionCustomErrorResponse), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCustomErrorResponse")]
    public interface ICloudfrontMultitenantDistributionCustomErrorResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#error_code CloudfrontMultitenantDistribution#error_code}.</summary>
        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}")]
        double ErrorCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#error_caching_min_ttl CloudfrontMultitenantDistribution#error_caching_min_ttl}.</summary>
        [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ErrorCachingMinTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#response_code CloudfrontMultitenantDistribution#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#response_page_path CloudfrontMultitenantDistribution#response_page_path}.</summary>
        [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponsePagePath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionCustomErrorResponse), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionCustomErrorResponse")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionCustomErrorResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#error_code CloudfrontMultitenantDistribution#error_code}.</summary>
            [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}")]
            public double ErrorCode
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#error_caching_min_ttl CloudfrontMultitenantDistribution#error_caching_min_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ErrorCachingMinTtl
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#response_code CloudfrontMultitenantDistribution#response_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#response_page_path CloudfrontMultitenantDistribution#response_page_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponsePagePath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
