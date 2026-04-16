using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleArchiveRule")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleArchiveRule : aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRule
    {
        /// <summary>archive_retain_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dlm_lifecycle_policy#archive_retain_rule DlmLifecyclePolicy#archive_retain_rule}
        /// </remarks>
        [JsiiProperty(name: "archiveRetainRule", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule\"}")]
        public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule ArchiveRetainRule
        {
            get;
            set;
        }
    }
}
