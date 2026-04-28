using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketPolicy
{
    [JsiiByValue(fqn: "scaleway.objectBucketPolicy.ObjectBucketPolicyTimeouts")]
    public class ObjectBucketPolicyTimeouts : scaleway.ObjectBucketPolicy.IObjectBucketPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket_policy#default ObjectBucketPolicy#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
