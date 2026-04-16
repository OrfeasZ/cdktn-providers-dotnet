using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketWebsiteConfiguration
{
    [JsiiInterface(nativeType: typeof(IObjectBucketWebsiteConfigurationIndexDocument), fullyQualifiedName: "scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationIndexDocument")]
    public interface IObjectBucketWebsiteConfigurationIndexDocument
    {
        /// <summary>Suffix that will be added to the index.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_website_configuration#suffix ObjectBucketWebsiteConfiguration#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        string Suffix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketWebsiteConfigurationIndexDocument), fullyQualifiedName: "scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationIndexDocument")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationIndexDocument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Suffix that will be added to the index.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_website_configuration#suffix ObjectBucketWebsiteConfiguration#suffix}
            /// </remarks>
            [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
            public string Suffix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
