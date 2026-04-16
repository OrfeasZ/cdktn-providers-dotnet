using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesBucket
{
    [JsiiInterface(nativeType: typeof(ISpacesBucketLifecycleRuleNoncurrentVersionExpiration), fullyQualifiedName: "digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration")]
    public interface ISpacesBucketLifecycleRuleNoncurrentVersionExpiration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#days SpacesBucket#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpacesBucketLifecycleRuleNoncurrentVersionExpiration), fullyQualifiedName: "digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration")]
        internal sealed class _Proxy : DeputyBase, digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/spaces_bucket#days SpacesBucket#days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
