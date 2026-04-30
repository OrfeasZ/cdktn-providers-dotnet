using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DlmLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule")]
    public interface IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule
    {
        /// <summary>retention_archive_tier block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dlm_lifecycle_policy#retention_archive_tier DlmLifecyclePolicy#retention_archive_tier}
        /// </remarks>
        [JsiiProperty(name: "retentionArchiveTier", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier\"}")]
        aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier RetentionArchiveTier
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule), fullyQualifiedName: "aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule")]
        internal sealed class _Proxy : DeputyBase, aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>retention_archive_tier block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/dlm_lifecycle_policy#retention_archive_tier DlmLifecyclePolicy#retention_archive_tier}
            /// </remarks>
            [JsiiProperty(name: "retentionArchiveTier", typeJson: "{\"fqn\":\"aws.dlmLifecyclePolicy.DlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier\"}")]
            public aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier RetentionArchiveTier
            {
                get => GetInstanceProperty<aws.DlmLifecyclePolicy.IDlmLifecyclePolicyPolicyDetailsScheduleArchiveRuleArchiveRetainRuleRetentionArchiveTier>()!;
            }
        }
    }
}
