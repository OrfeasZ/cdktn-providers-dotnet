using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule : aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule
    {
        /// <summary>retention_archive_tier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/dlm_lifecycle_policy#retention_archive_tier DlmLifecyclePolicy#retention_archive_tier}
        /// </remarks>
        [JsiiProperty(name: "retentionArchiveTier", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier\"}")]
        public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier RetentionArchiveTier
        {
            get;
            set;
        }
    }
}
