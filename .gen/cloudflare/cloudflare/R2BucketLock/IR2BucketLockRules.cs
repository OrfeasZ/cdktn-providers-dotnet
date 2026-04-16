using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLock
{
    [JsiiInterface(nativeType: typeof(IR2BucketLockRules), fullyQualifiedName: "cloudflare.r2BucketLock.R2BucketLockRules")]
    public interface IR2BucketLockRules
    {
        /// <summary>Condition to apply a lock rule to an object for how long in seconds.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#condition R2BucketLock#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLock.R2BucketLockRulesCondition\"}")]
        cloudflare.R2BucketLock.IR2BucketLockRulesCondition Condition
        {
            get;
        }

        /// <summary>Whether or not this rule is in effect.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#enabled R2BucketLock#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Unique identifier for this rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#id R2BucketLock#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Rule will only apply to objects/uploads in the bucket that start with the given prefix, an empty prefix can be provided to scope rule to all objects/uploads.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#prefix R2BucketLock#prefix}
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketLockRules), fullyQualifiedName: "cloudflare.r2BucketLock.R2BucketLockRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketLock.IR2BucketLockRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Condition to apply a lock rule to an object for how long in seconds.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#condition R2BucketLock#condition}
            /// </remarks>
            [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.r2BucketLock.R2BucketLockRulesCondition\"}")]
            public cloudflare.R2BucketLock.IR2BucketLockRulesCondition Condition
            {
                get => GetInstanceProperty<cloudflare.R2BucketLock.IR2BucketLockRulesCondition>()!;
            }

            /// <summary>Whether or not this rule is in effect.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#enabled R2BucketLock#enabled}
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Unique identifier for this rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#id R2BucketLock#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Rule will only apply to objects/uploads in the bucket that start with the given prefix, an empty prefix can be provided to scope rule to all objects/uploads.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lock#prefix R2BucketLock#prefix}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
