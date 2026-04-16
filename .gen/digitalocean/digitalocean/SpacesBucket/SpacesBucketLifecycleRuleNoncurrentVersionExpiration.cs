using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesBucket
{
    [JsiiByValue(fqn: "digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration")]
    public class SpacesBucketLifecycleRuleNoncurrentVersionExpiration : digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#days SpacesBucket#days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Days
        {
            get;
            set;
        }
    }
}
