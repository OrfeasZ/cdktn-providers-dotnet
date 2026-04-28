using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketWebsiteConfiguration
{
    [JsiiInterface(nativeType: typeof(IObjectBucketWebsiteConfigurationErrorDocument), fullyQualifiedName: "scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationErrorDocument")]
    public interface IObjectBucketWebsiteConfigurationErrorDocument
    {
        /// <summary>Key for the object to use as an error document.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_website_configuration#key ObjectBucketWebsiteConfiguration#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketWebsiteConfigurationErrorDocument), fullyQualifiedName: "scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationErrorDocument")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationErrorDocument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Key for the object to use as an error document.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_website_configuration#key ObjectBucketWebsiteConfiguration#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
