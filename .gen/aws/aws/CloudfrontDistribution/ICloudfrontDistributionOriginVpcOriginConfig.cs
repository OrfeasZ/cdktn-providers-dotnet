using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginVpcOriginConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfig")]
    public interface ICloudfrontDistributionOriginVpcOriginConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#vpc_origin_id CloudfrontDistribution#vpc_origin_id}.</summary>
        [JsiiProperty(name: "vpcOriginId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcOriginId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#origin_keepalive_timeout CloudfrontDistribution#origin_keepalive_timeout}.</summary>
        [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginKeepaliveTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#origin_read_timeout CloudfrontDistribution#origin_read_timeout}.</summary>
        [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginReadTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#owner_account_id CloudfrontDistribution#owner_account_id}.</summary>
        [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OwnerAccountId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginVpcOriginConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOriginVpcOriginConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionOriginVpcOriginConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#vpc_origin_id CloudfrontDistribution#vpc_origin_id}.</summary>
            [JsiiProperty(name: "vpcOriginId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcOriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#origin_keepalive_timeout CloudfrontDistribution#origin_keepalive_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginKeepaliveTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#origin_read_timeout CloudfrontDistribution#origin_read_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginReadTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_distribution#owner_account_id CloudfrontDistribution#owner_account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ownerAccountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OwnerAccountId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
