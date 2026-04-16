using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.ObjectBucketLockConfiguration
{
    [JsiiClass(nativeType: typeof(scaleway.ObjectBucketLockConfiguration.ObjectBucketLockConfigurationRuleOutputReference), fullyQualifiedName: "scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ObjectBucketLockConfigurationRuleOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ObjectBucketLockConfigurationRuleOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ObjectBucketLockConfigurationRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ObjectBucketLockConfigurationRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultRetention", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetention\"}}]")]
        public virtual void PutDefaultRetention(scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention)}, new object[]{@value});
        }

        [JsiiProperty(name: "defaultRetention", typeJson: "{\"fqn\":\"scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetentionOutputReference\"}")]
        public virtual scaleway.ObjectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetentionOutputReference DefaultRetention
        {
            get => GetInstanceProperty<scaleway.ObjectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetentionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultRetentionInput", typeJson: "{\"fqn\":\"scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRuleDefaultRetention\"}", isOptional: true)]
        public virtual scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention? DefaultRetentionInput
        {
            get => GetInstanceProperty<scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRuleDefaultRetention?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"scaleway.objectBucketLockConfiguration.ObjectBucketLockConfigurationRule\"}", isOptional: true)]
        public virtual scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRule? InternalValue
        {
            get => GetInstanceProperty<scaleway.ObjectBucketLockConfiguration.IObjectBucketLockConfigurationRule?>();
            set => SetInstanceProperty(value);
        }
    }
}
