using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingGroup
{
    [JsiiByValue(fqn: "aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicy")]
    public class AutoscalingGroupInstanceLifecyclePolicy : aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicy
    {
        /// <summary>retention_triggers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/autoscaling_group#retention_triggers AutoscalingGroup#retention_triggers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retentionTriggers", typeJson: "{\"fqn\":\"aws.autoscalingGroup.AutoscalingGroupInstanceLifecyclePolicyRetentionTriggers\"}", isOptional: true)]
        public aws.AutoscalingGroup.IAutoscalingGroupInstanceLifecyclePolicyRetentionTriggers? RetentionTriggers
        {
            get;
            set;
        }
    }
}
