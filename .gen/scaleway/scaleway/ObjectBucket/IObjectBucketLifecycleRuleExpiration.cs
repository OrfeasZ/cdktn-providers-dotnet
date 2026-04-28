using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucket
{
    [JsiiInterface(nativeType: typeof(IObjectBucketLifecycleRuleExpiration), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleExpiration")]
    public interface IObjectBucketLifecycleRuleExpiration
    {
        /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket#days ObjectBucket#days}
        /// </remarks>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
        double Days
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketLifecycleRuleExpiration), fullyQualifiedName: "scaleway.objectBucket.ObjectBucketLifecycleRuleExpiration")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucket.IObjectBucketLifecycleRuleExpiration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the number of days after object creation when the specific rule action takes effect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/object_bucket#days ObjectBucket#days}
            /// </remarks>
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
            public double Days
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
