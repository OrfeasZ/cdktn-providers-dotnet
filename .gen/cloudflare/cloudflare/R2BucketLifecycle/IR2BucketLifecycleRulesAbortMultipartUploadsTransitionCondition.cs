using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.R2BucketLifecycle
{
    [JsiiInterface(nativeType: typeof(IR2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition")]
    public interface IR2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#max_age R2BucketLifecycle#max_age}.</summary>
        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}")]
        double MaxAge
        {
            get;
        }

        /// <summary>Available values: "Age".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#type R2BucketLifecycle#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IR2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition), fullyQualifiedName: "cloudflare.r2BucketLifecycle.R2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition")]
        internal sealed class _Proxy : DeputyBase, cloudflare.R2BucketLifecycle.IR2BucketLifecycleRulesAbortMultipartUploadsTransitionCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#max_age R2BucketLifecycle#max_age}.</summary>
            [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxAge
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Available values: "Age".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/r2_bucket_lifecycle#type R2BucketLifecycle#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
