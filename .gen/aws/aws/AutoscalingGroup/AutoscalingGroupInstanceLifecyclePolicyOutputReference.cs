using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyOutputReference), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupInstanceLifecyclePolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupInstanceLifecyclePolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutoscalingGroupInstanceLifecyclePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceLifecyclePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRetentionTriggers", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers\"}}]")]
        public virtual void PutRetentionTriggers(aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRetentionTriggers")]
        public virtual void ResetRetentionTriggers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "retentionTriggers", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference\"}")]
        public virtual aws.AutoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference RetentionTriggers
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionTriggersInput", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers? RetentionTriggersInput
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicy\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicy? InternalValue
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
