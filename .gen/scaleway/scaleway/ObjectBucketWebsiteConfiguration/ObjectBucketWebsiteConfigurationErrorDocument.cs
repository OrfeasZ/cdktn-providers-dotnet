using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketWebsiteConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationErrorDocument")]
    public class ObjectBucketWebsiteConfigurationErrorDocument : scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationErrorDocument
    {
        /// <summary>Key for the object to use as an error document.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_website_configuration#key ObjectBucketWebsiteConfiguration#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }
    }
}
