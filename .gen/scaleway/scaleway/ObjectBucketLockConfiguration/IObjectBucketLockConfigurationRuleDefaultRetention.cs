using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketLockConfiguration
{
    [JsiiInterface(nativeType: typeof(IObjectBucketLockConfigurationRuleDefaultRetention), fullyQualifiedName: "scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetention")]
    public interface IObjectBucketLockConfigurationRuleDefaultRetention
    {
        /// <summary>The default Object Lock retention mode you want to apply to new objects placed in the specified bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#mode ObjectBucketLockConfiguration#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>The number of days that you want to specify for the default retention period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#days ObjectBucketLockConfiguration#days}
        /// </remarks>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Days
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of years that you want to specify for the default retention period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#years ObjectBucketLockConfiguration#years}
        /// </remarks>
        [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Years
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObjectBucketLockConfigurationRuleDefaultRetention), fullyQualifiedName: "scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetention")]
        internal sealed class _Proxy : DeputyBase, scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The default Object Lock retention mode you want to apply to new objects placed in the specified bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#mode ObjectBucketLockConfiguration#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of days that you want to specify for the default retention period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#days ObjectBucketLockConfiguration#days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Days
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of years that you want to specify for the default retention period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/object_bucket_lock_configuration#years ObjectBucketLockConfiguration#years}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "years", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Years
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
