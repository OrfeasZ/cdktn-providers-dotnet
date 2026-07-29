using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiInterface(nativeType: typeof(IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers")]
    public interface IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/autoscaling_group#terminate_hook_abandon AutoscalingGroup#terminate_hook_abandon}.</summary>
        [JsiiProperty(name: "terminateHookAbandon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TerminateHookAbandon
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers), fullyQualifiedName: "aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/autoscaling_group#terminate_hook_abandon AutoscalingGroup#terminate_hook_abandon}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminateHookAbandon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TerminateHookAbandon
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
