using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiInterface(nativeType: typeof(IAccessPackageAssignmentPolicyApprovalSettings), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettings")]
    public interface IAccessPackageAssignmentPolicyApprovalSettings
    {
        /// <summary>Whether an approval is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approval_required AccessPackageAssignmentPolicy#approval_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "approvalRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApprovalRequired
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approval_required_for_extension AccessPackageAssignmentPolicy#approval_required_for_extension}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "approvalRequiredForExtension", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApprovalRequiredForExtension
        {
            get
            {
                return null;
            }
        }

        /// <summary>approval_stage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approval_stage AccessPackageAssignmentPolicy#approval_stage}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "approvalStage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettingsApprovalStage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApprovalStage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether requestor are required to provide a justification to request an access package.</summary>
        /// <remarks>
        /// Justification is visible to other approvers and the requestor
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#requestor_justification_required AccessPackageAssignmentPolicy#requestor_justification_required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requestorJustificationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestorJustificationRequired
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessPackageAssignmentPolicyApprovalSettings), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettings")]
        internal sealed class _Proxy : DeputyBase, azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether an approval is required.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approval_required AccessPackageAssignmentPolicy#approval_required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approvalRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ApprovalRequired
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether an approval is required to grant extension. Same approval settings used to approve initial access will apply.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approval_required_for_extension AccessPackageAssignmentPolicy#approval_required_for_extension}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approvalRequiredForExtension", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ApprovalRequiredForExtension
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>approval_stage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#approval_stage AccessPackageAssignmentPolicy#approval_stage}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "approvalStage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettingsApprovalStage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApprovalStage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether requestor are required to provide a justification to request an access package.</summary>
            /// <remarks>
            /// Justification is visible to other approvers and the requestor
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#requestor_justification_required AccessPackageAssignmentPolicy#requestor_justification_required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestorJustificationRequired", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequestorJustificationRequired
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
