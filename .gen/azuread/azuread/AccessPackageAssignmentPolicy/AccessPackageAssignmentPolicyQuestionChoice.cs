using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoice")]
    public class AccessPackageAssignmentPolicyQuestionChoice : azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice
    {
        /// <summary>The actual value of this choice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#actual_value AccessPackageAssignmentPolicy#actual_value}
        /// </remarks>
        [JsiiProperty(name: "actualValue", typeJson: "{\"primitive\":\"string\"}")]
        public string ActualValue
        {
            get;
            set;
        }

        /// <summary>display_value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#display_value AccessPackageAssignmentPolicy#display_value}
        /// </remarks>
        [JsiiProperty(name: "displayValue", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValue\"}")]
        public azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue DisplayValue
        {
            get;
            set;
        }
    }
}
