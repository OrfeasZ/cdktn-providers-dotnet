using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionText")]
    public class AccessPackageAssignmentPolicyQuestionText : azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText
    {
        /// <summary>The default text of this question.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#default_text AccessPackageAssignmentPolicy#default_text}
        /// </remarks>
        [JsiiProperty(name: "defaultText", typeJson: "{\"primitive\":\"string\"}")]
        public string DefaultText
        {
            get;
            set;
        }

        private object? _localizedText;

        /// <summary>localized_text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#localized_text AccessPackageAssignmentPolicy#localized_text}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionTextLocalizedText" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localizedText", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionTextLocalizedText\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LocalizedText
        {
            get => _localizedText;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionTextLocalizedText[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionTextLocalizedText).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _localizedText = value;
            }
        }
    }
}
