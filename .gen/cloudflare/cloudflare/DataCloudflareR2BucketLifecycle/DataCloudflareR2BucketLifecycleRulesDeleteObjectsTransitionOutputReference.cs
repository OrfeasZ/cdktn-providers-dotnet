using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareR2BucketLifecycle
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareR2BucketLifecycle.DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareR2BucketLifecycle.DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "condition", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2BucketLifecycle.DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionConditionOutputReference\"}")]
        public virtual cloudflare.DataCloudflareR2BucketLifecycle.DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionConditionOutputReference Condition
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2BucketLifecycle.DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransitionConditionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2BucketLifecycle.DataCloudflareR2BucketLifecycleRulesDeleteObjectsTransition\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareR2BucketLifecycle.IDataCloudflareR2BucketLifecycleRulesDeleteObjectsTransition? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2BucketLifecycle.IDataCloudflareR2BucketLifecycleRulesDeleteObjectsTransition?>();
            set => SetInstanceProperty(value);
        }
    }
}
