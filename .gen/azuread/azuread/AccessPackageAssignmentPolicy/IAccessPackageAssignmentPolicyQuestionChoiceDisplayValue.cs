using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiInterface(nativeType: typeof(IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValue")]
    public interface IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue
    {
        /// <summary>The default text of this question.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#default_text AccessPackageAssignmentPolicy#default_text}
        /// </remarks>
        [JsiiProperty(name: "defaultText", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultText
        {
            get;
        }

        /// <summary>localized_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#localized_text AccessPackageAssignmentPolicy#localized_text}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "localizedText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LocalizedText
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValue")]
        internal sealed class _Proxy : DeputyBase, azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The default text of this question.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#default_text AccessPackageAssignmentPolicy#default_text}
            /// </remarks>
            [JsiiProperty(name: "defaultText", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultText
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>localized_text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#localized_text AccessPackageAssignmentPolicy#localized_text}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "localizedText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoiceDisplayValueLocalizedText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LocalizedText
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
