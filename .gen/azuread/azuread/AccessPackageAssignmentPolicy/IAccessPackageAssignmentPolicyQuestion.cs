using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiInterface(nativeType: typeof(IAccessPackageAssignmentPolicyQuestion), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestion")]
    public interface IAccessPackageAssignmentPolicyQuestion
    {
        /// <summary>text block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#text AccessPackageAssignmentPolicy#text}
        /// </remarks>
        [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionText\"}")]
        azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText Text
        {
            get;
        }

        /// <summary>choice block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#choice AccessPackageAssignmentPolicy#choice}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "choice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Choice
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this question is required.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#required AccessPackageAssignmentPolicy#required}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Required
        {
            get
            {
                return null;
            }
        }

        /// <summary>The sequence number of this question.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#sequence AccessPackageAssignmentPolicy#sequence}
        /// </remarks>
        [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Sequence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessPackageAssignmentPolicyQuestion), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestion")]
        internal sealed class _Proxy : DeputyBase, azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>text block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#text AccessPackageAssignmentPolicy#text}
            /// </remarks>
            [JsiiProperty(name: "text", typeJson: "{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionText\"}")]
            public azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText Text
            {
                get => GetInstanceProperty<azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionText>()!;
            }

            /// <summary>choice block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#choice AccessPackageAssignmentPolicy#choice}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyQuestionChoice" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "choice", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyQuestionChoice\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Choice
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether this question is required.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#required AccessPackageAssignmentPolicy#required}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Required
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The sequence number of this question.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#sequence AccessPackageAssignmentPolicy#sequence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sequence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Sequence
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
