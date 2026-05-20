using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionCacheTagConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionCacheTagConfig")]
    public interface ICloudfrontDistributionCacheTagConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/cloudfront_distribution#header_name CloudfrontDistribution#header_name}.</summary>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionCacheTagConfig), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionCacheTagConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionCacheTagConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/cloudfront_distribution#header_name CloudfrontDistribution#header_name}.</summary>
            [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
