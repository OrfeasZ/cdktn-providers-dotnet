using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiByValue(fqn: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyAssignmentReviewSettings")]
    public class AccessPackageAssignmentPolicyAssignmentReviewSettings : azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyAssignmentReviewSettings
    {
        private object? _accessRecommendationEnabled;

        /// <summary>Whether to show Show reviewer decision helpers.</summary>
        /// <remarks>
        /// If enabled, system recommendations based on users' access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#access_recommendation_enabled AccessPackageAssignmentPolicy#access_recommendation_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessRecommendationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AccessRecommendationEnabled
        {
            get => _accessRecommendationEnabled;
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
                _accessRecommendationEnabled = value;
            }
        }

        /// <summary>What actions the system takes if reviewers don't respond in time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#access_review_timeout_behavior AccessPackageAssignmentPolicy#access_review_timeout_behavior}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessReviewTimeoutBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccessReviewTimeoutBehavior
        {
            get;
            set;
        }

        private object? _approverJustificationRequired;

        /// <summary>Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor.</summary>
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

        /// <summary>How many days each occurrence of the access review series will run.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#duration_in_days AccessPackageAssignmentPolicy#duration_in_days}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationInDays
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Whether to enable assignment review.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#enabled AccessPackageAssignmentPolicy#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }

        private object? _reviewer;

        /// <summary>reviewer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#reviewer AccessPackageAssignmentPolicy#reviewer}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyAssignmentReviewSettingsReviewer" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reviewer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyAssignmentReviewSettingsReviewer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Reviewer
        {
            get => _reviewer;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyAssignmentReviewSettingsReviewer[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyAssignmentReviewSettingsReviewer).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _reviewer = value;
            }
        }

        /// <summary>This will determine how often the access review campaign runs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#review_frequency AccessPackageAssignmentPolicy#review_frequency}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reviewFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReviewFrequency
        {
            get;
            set;
        }

        /// <summary>Self review or specific reviewers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#review_type AccessPackageAssignmentPolicy#review_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reviewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReviewType
        {
            get;
            set;
        }

        /// <summary>This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#starting_on AccessPackageAssignmentPolicy#starting_on}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "startingOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartingOn
        {
            get;
            set;
        }
    }
}
