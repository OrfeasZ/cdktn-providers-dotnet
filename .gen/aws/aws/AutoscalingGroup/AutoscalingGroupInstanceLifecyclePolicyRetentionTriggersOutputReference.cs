using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiClass(nativeType: typeof(aws.AutoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutoscalingGroupInstanceLifecyclePolicyRetentionTriggersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTerminateHookAbandon")]
        public virtual void ResetTerminateHookAbandon()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminateHookAbandonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TerminateHookAbandonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "terminateHookAbandon", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TerminateHookAbandon
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers\"}", isOptional: true)]
        public virtual aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers? InternalValue
        {
            get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers?>();
            set => SetInstanceProperty(value);
        }
    }
}
