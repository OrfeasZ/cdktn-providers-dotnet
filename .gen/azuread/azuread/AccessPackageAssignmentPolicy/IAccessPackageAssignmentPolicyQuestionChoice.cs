using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiInterface(nativeType: typeof(IAccessPackageAssignmentPolicyQuestionChoice), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoice")]
    public interface IAccessPackageAssignmentPolicyQuestionChoice
    {
        /// <summary>The actual value of this choice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#actual_value AccessPackageAssignmentPolicy#actual_value}
        /// </remarks>
        [JsiiProperty(name: "actualValue", typeJson: "{\"primitive\":\"string\"}")]
        string ActualValue
        {
            get;
        }

        /// <summary>display_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#display_value AccessPackageAssignmentPolicy#display_value}
        /// </remarks>
        [JsiiProperty(name: "displayValue", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValue\"}")]
        azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue DisplayValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessPackageAssignmentPolicyQuestionChoice), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoice")]
        internal sealed class _Proxy : DeputyBase, azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The actual value of this choice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#actual_value AccessPackageAssignmentPolicy#actual_value}
            /// </remarks>
            [JsiiProperty(name: "actualValue", typeJson: "{\"primitive\":\"string\"}")]
            public string ActualValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>display_value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#display_value AccessPackageAssignmentPolicy#display_value}
            /// </remarks>
            [JsiiProperty(name: "displayValue", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValue\"}")]
            public azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue DisplayValue
            {
                get => GetInstanceProperty<azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue>()!;
            }
        }
    }
}
