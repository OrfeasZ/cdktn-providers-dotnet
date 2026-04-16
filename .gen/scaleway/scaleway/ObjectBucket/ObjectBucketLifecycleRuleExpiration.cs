using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.objectBucket.ObjectBucketLifecycleRuleExpiration")]
    public class ObjectBucketLifecycleRuleExpiration : scaleway.ObjectBucket.IObjectBucketLifecycleRuleExpiration
    {
        /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket#days ObjectBucket#days}
        /// </remarks>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
        public double Days
        {
            get;
            set;
        }
    }
}
