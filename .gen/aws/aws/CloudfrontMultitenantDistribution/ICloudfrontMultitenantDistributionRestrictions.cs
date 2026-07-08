using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontMultitenantDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontMultitenantDistributionRestrictions), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictions")]
    public interface ICloudfrontMultitenantDistributionRestrictions
    {
        /// <summary>geo_restriction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/cloudfront_multitenant_distribution#geo_restriction CloudfrontMultitenantDistribution#geo_restriction}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionRestrictionsGeoRestriction" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "geoRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictionsGeoRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GeoRestriction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontMultitenantDistributionRestrictions), fullyQualifiedName: "aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictions")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionRestrictions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>geo_restriction block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/cloudfront_multitenant_distribution#geo_restriction CloudfrontMultitenantDistribution#geo_restriction}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.CloudfrontMultitenantDistribution.ICloudfrontMultitenantDistributionRestrictionsGeoRestriction" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "geoRestriction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontMultitenantDistribution.CloudfrontMultitenantDistributionRestrictionsGeoRestriction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GeoRestriction
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
