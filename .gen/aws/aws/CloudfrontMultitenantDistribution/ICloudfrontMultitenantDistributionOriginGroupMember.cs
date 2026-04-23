using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionOriginGroupMember), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupMember")]
    public interface ICloudfrontMultitenantDistributionOriginGroupMember
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_id CloudfrontMultitenantDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        string OriginId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionOriginGroupMember), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionOriginGroupMember")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionOriginGroupMember
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudfront_multitenant_distribution#origin_id CloudfrontMultitenantDistribution#origin_id}.</summary>
            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
