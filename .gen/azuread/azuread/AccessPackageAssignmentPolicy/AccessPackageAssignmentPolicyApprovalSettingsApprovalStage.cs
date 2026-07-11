using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettingsApprovalStage")]
    public class AccessPackageAssignmentPolicyApprovalSettingsApprovalStage : azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStage
    {
        /// <summary>Decision must be made in how many days?</summary>
        /// <remarks>
        /// If a request is not approved within this time period after it is made, it will be automatically rejected
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approval_timeout_in_days AccessPackageAssignmentPolicy#approval_timeout_in_days}
        /// </remarks>
        [JsiiProperty(name: "approvalTimeoutInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double ApprovalTimeoutInDays
        {
            get;
            set;
        }

        private object? _alternativeApprovalEnabled;

        /// <summary>If no action taken, forward to alternate approvers?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#alternative_approval_enabled AccessPackageAssignmentPolicy#alternative_approval_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alternativeApprovalEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AlternativeApprovalEnabled
        {
            get => _alternativeApprovalEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _alternativeApprovalEnabled = value;
            }
        }

        private object? _alternativeApprover;

        /// <summary>alternative_approver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#alternative_approver AccessPackageAssignmentPolicy#alternative_approver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alternativeApprover", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AlternativeApprover
        {
            get => _alternativeApprover;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _alternativeApprover = value;
            }
        }

        private object? _approverJustificationRequired;

        /// <summary>Whether an approver must provide a justification for their decision. Justification is visible to other approvers and the requestor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approver_justification_required AccessPackageAssignmentPolicy#approver_justification_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "approverJustificationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? ApproverJustificationRequired
        {
            get => _approverJustificationRequired;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _approverJustificationRequired = value;
            }
        }

        /// <summary>Forward to alternate approver(s) after how many days?</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#enable_alternative_approval_in_days AccessPackageAssignmentPolicy#enable_alternative_approval_in_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableAlternativeApprovalInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? EnableAlternativeApprovalInDays
        {
            get;
            set;
        }

        private object? _primaryApprover;

        /// <summary>primary_approver block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#primary_approver AccessPackageAssignmentPolicy#primary_approver}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStagePrimaryApprover" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "primaryApprover", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettingsApprovalStagePrimaryApprover\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PrimaryApprover
        {
            get => _primaryApprover;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStagePrimaryApprover[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStagePrimaryApprover).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _primaryApprover = value;
            }
        }
    }
}
