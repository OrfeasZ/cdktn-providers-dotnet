using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareR2BucketLock
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareR2BucketLock.DataCloudflareR2BucketLockRulesConditionOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareR2BucketLock.DataCloudflareR2BucketLockRulesConditionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareR2BucketLockRulesConditionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareR2BucketLockRulesConditionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareR2BucketLockRulesConditionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareR2BucketLockRulesConditionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Date
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxAgeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAgeSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2BucketLock.DataCloudflareR2BucketLockRulesCondition\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareR2BucketLock.IDataCloudflareR2BucketLockRulesCondition? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2BucketLock.IDataCloudflareR2BucketLockRulesCondition?>();
            set => SetInstanceProperty(value);
        }
    }
}
