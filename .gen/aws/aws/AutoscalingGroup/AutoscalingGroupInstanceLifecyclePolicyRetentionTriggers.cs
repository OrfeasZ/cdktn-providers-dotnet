using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers")]
    public class AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers : aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.58.0/docs/resources/autoscaling_group#terminate_hook_abandon AutoscalingGroup#terminate_hook_abandon}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminateHookAbandon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TerminateHookAbandon
        {
            get;
            set;
        }
    }
}
