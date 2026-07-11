using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiInterface(nativeType: typeof(IAccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover")]
    public interface IAccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover
    {
        /// <summary>Type of users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#subject_type AccessPackageAssignmentPolicy#subject_type}
        /// </remarks>
        [JsiiProperty(name: "subjectType", typeJson: "{\"primitive\":\"string\"}")]
        string SubjectType
        {
            get;
        }

        /// <summary>For a user in an approval stage, this property indicates whether the user is a backup fallback approver.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#backup AccessPackageAssignmentPolicy#backup}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "backup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Backup
        {
            get
            {
                return null;
            }
        }

        /// <summary>The object ID of the subject.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#object_id AccessPackageAssignmentPolicy#object_id}
        /// </remarks>
        [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover")]
        internal sealed class _Proxy : DeputyBase, azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyApprovalSettingsApprovalStageAlternativeApprover
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of users.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#subject_type AccessPackageAssignmentPolicy#subject_type}
            /// </remarks>
            [JsiiProperty(name: "subjectType", typeJson: "{\"primitive\":\"string\"}")]
            public string SubjectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>For a user in an approval stage, this property indicates whether the user is a backup fallback approver.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#backup AccessPackageAssignmentPolicy#backup}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backup", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Backup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The object ID of the subject.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#object_id AccessPackageAssignmentPolicy#object_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
