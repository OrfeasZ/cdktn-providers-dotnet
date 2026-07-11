using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestion")]
    public class AccessPackageAssignmentPolicyQuestion : azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestion
    {
        /// <summary>text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#text AccessPackageAssignmentPolicy#text}
        /// </remarks>
        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionText\"}")]
        public azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText Text
        {
            get;
            set;
        }

        private object? _choice;

        /// <summary>choice block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#choice AccessPackageAssignmentPolicy#choice}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "choice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Choice
        {
            get => _choice;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _choice = value;
            }
        }

        private object? _required;

        /// <summary>Whether this question is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#required AccessPackageAssignmentPolicy#required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Required
        {
            get => _required;
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
                _required = value;
            }
        }

        /// <summary>The sequence number of this question.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#sequence AccessPackageAssignmentPolicy#sequence}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Sequence
        {
            get;
            set;
        }
    }
}
