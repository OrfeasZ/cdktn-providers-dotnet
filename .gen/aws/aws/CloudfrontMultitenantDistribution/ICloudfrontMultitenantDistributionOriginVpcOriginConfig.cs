using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionOriginVpcOriginConfig), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginVpcOriginConfig")]
    public interface ICloudfrontMultitenantDistributionOriginVpcOriginConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#vpc_origin_id CloudfrontMultitenantDistribution#vpc_origin_id}.</summary>
        [JsiiProperty(name: "vpcOriginId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcOriginId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_keepalive_timeout CloudfrontMultitenantDistribution#origin_keepalive_timeout}.</summary>
        [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginKeepaliveTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_read_timeout CloudfrontMultitenantDistribution#origin_read_timeout}.</summary>
        [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? OriginReadTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionOriginVpcOriginConfig), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginVpcOriginConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginVpcOriginConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#vpc_origin_id CloudfrontMultitenantDistribution#vpc_origin_id}.</summary>
            [JsiiProperty(name: "vpcOriginId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcOriginId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_keepalive_timeout CloudfrontMultitenantDistribution#origin_keepalive_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originKeepaliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginKeepaliveTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudfront_multitenant_distribution#origin_read_timeout CloudfrontMultitenantDistribution#origin_read_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "originReadTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? OriginReadTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
