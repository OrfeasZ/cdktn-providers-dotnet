using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.SpacesBucket
{
    [JsiiClass(nativeType: typeof(digitalocean.SpacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference), fullyQualifiedName: "digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpacesBucketLifecycleRuleNoncurrentVersionExpirationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDays")]
        public virtual void ResetDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Days
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.spacesBucket.SpacesBucketLifecycleRuleNoncurrentVersionExpiration\"}", isOptional: true)]
        public virtual digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration? InternalValue
        {
            get => GetInstanceProperty<digitalocean.SpacesBucket.ISpacesBucketLifecycleRuleNoncurrentVersionExpiration?>();
            set => SetInstanceProperty(value);
        }
    }
}
