using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiInterface(nativeType: typeof(IAccessPackageAssignmentPolicyAssignmentReviewSettings), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyAssignmentReviewSettings")]
    public interface IAccessPackageAssignmentPolicyAssignmentReviewSettings
    {
        /// <summary>Whether to show Show reviewer decision helpers.</summary>
        /// <remarks>
        /// If enabled, system recommendations based on users' access information will be shown to the reviewers. The reviewer will be recommended to approve the review if the user has signed-in at least once during the last 30 days. The reviewer will be recommended to deny the review if the user has not signed-in during the last 30 days
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#access_recommendation_enabled AccessPackageAssignmentPolicy#access_recommendation_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "accessRecommendationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AccessRecommendationEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>What actions the system takes if reviewers don't respond in time.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#access_review_timeout_behavior AccessPackageAssignmentPolicy#access_review_timeout_behavior}
        /// </remarks>
        [JsiiProperty(name: "accessReviewTimeoutBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccessReviewTimeoutBehavior
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approver_justification_required AccessPackageAssignmentPolicy#approver_justification_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "approverJustificationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApproverJustificationRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>How many days each occurrence of the access review series will run.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#duration_in_days AccessPackageAssignmentPolicy#duration_in_days}
        /// </remarks>
        [JsiiProperty(name: "durationInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DurationInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable assignment review.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#enabled AccessPackageAssignmentPolicy#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>reviewer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#reviewer AccessPackageAssignmentPolicy#reviewer}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyAssignmentReviewSettingsReviewer" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "reviewer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyAssignmentReviewSettingsReviewer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Reviewer
        {
            get
            {
                return null;
            }
        }

        /// <summary>This will determine how often the access review campaign runs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#review_frequency AccessPackageAssignmentPolicy#review_frequency}
        /// </remarks>
        [JsiiProperty(name: "reviewFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReviewFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Self review or specific reviewers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#review_type AccessPackageAssignmentPolicy#review_type}
        /// </remarks>
        [JsiiProperty(name: "reviewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReviewType
        {
            get
            {
                return null;
            }
        }

        /// <summary>This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#starting_on AccessPackageAssignmentPolicy#starting_on}
        /// </remarks>
        [JsiiProperty(name: "startingOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartingOn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessPackageAssignmentPolicyAssignmentReviewSettings), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyAssignmentReviewSettings")]
        internal sealed class _Proxy : DeputyBase, azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyAssignmentReviewSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<object?>();
            }

            /// <summary>What actions the system takes if reviewers don't respond in time.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#access_review_timeout_behavior AccessPackageAssignmentPolicy#access_review_timeout_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessReviewTimeoutBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccessReviewTimeoutBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether a reviewer need provide a justification for their decision. Justification is visible to other reviewers and the requestor.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approver_justification_required AccessPackageAssignmentPolicy#approver_justification_required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approverJustificationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ApproverJustificationRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>How many days each occurrence of the access review series will run.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#duration_in_days AccessPackageAssignmentPolicy#duration_in_days}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "durationInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DurationInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Whether to enable assignment review.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#enabled AccessPackageAssignmentPolicy#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>reviewer block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#reviewer AccessPackageAssignmentPolicy#reviewer}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyAssignmentReviewSettingsReviewer" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reviewer", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyAssignmentReviewSettingsReviewer\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Reviewer
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>This will determine how often the access review campaign runs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#review_frequency AccessPackageAssignmentPolicy#review_frequency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reviewFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReviewFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Self review or specific reviewers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#review_type AccessPackageAssignmentPolicy#review_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reviewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReviewType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>This is the date the access review campaign will start on, formatted as an RFC3339 date string in UTC(e.g. 2018-01-01T01:02:03Z), default is now. Once an access review has been created, you cannot update its start date.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#starting_on AccessPackageAssignmentPolicy#starting_on}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startingOn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartingOn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
