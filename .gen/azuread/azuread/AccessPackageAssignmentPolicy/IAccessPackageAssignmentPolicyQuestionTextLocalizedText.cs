using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiInterface(nativeType: typeof(IAccessPackageAssignmentPolicyQuestionTextLocalizedText), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionTextLocalizedText")]
    public interface IAccessPackageAssignmentPolicyQuestionTextLocalizedText
    {
        /// <summary>The localized content of this question.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#content AccessPackageAssignmentPolicy#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>The language code of this question content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#language_code AccessPackageAssignmentPolicy#language_code}
        /// </remarks>
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}")]
        string LanguageCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessPackageAssignmentPolicyQuestionTextLocalizedText), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionTextLocalizedText")]
        internal sealed class _Proxy : DeputyBase, azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionTextLocalizedText
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The localized content of this question.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#content AccessPackageAssignmentPolicy#content}
            /// </remarks>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The language code of this question content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#language_code AccessPackageAssignmentPolicy#language_code}
            /// </remarks>
            [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}")]
            public string LanguageCode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
