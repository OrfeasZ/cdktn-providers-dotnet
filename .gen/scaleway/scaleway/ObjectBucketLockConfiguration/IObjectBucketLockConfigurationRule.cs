using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketLockConfiguration
{
    [JsiiInterface(nativeType: typeof(IObjectBucketLockConfigurationRule), fullyQualifiedName: "scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRule")]
    public interface IObjectBucketLockConfigurationRule
    {
        /// <summary>default_retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#default_retention ObjectBucketLockConfiguration#default_retention}
        /// </remarks>
        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetention\"}")]
        scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention DefaultRetention
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketLockConfigurationRule), fullyQualifiedName: "scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_retention block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#default_retention ObjectBucketLockConfiguration#default_retention}
            /// </remarks>
            [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetention\"}")]
            public scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention DefaultRetention
            {
                get => GetInstanceProperty<scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention>()!;
            }
        }
    }
}
