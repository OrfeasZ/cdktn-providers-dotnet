using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketWebsiteConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucketWebsiteConfiguration.ObjectBucketWebsiteConfigurationIndexDocument")]
    public class ObjectBucketWebsiteConfigurationIndexDocument : scaleway.ObjectBucketWebsiteConfiguration.IObjectBucketWebsiteConfigurationIndexDocument
    {
        /// <summary>Suffix that will be added to the index.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_website_configuration#suffix ObjectBucketWebsiteConfiguration#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        public string Suffix
        {
            get;
            set;
        }
    }
}
