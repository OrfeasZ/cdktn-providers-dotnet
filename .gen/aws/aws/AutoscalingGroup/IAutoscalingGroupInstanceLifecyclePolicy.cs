using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupInstanceLifecyclePolicy), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicy")]
    public interface IAutoscalingGroupInstanceLifecyclePolicy
    {
        /// <summary>retention_triggers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/autoscaling_group#retention_triggers AutoscalingGroup#retention_triggers}
        /// </remarks>
        [JsiiProperty(name: "retentionTriggers", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers? RetentionTriggers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupInstanceLifecyclePolicy), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>retention_triggers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/autoscaling_group#retention_triggers AutoscalingGroup#retention_triggers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionTriggers", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers\"}", isOptional: true)]
            public aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers? RetentionTriggers
            {
                get => GetInstanceProperty<aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers?>();
            }
        }
    }
}
