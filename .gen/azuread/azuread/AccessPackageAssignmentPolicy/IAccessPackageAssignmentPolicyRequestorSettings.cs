using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.AccessPackageAssignmentPolicy
{
    [JsiiInterface(nativeType: typeof(IAccessPackageAssignmentPolicyRequestorSettings), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyRequestorSettings")]
    public interface IAccessPackageAssignmentPolicyRequestorSettings
    {
        /// <summary>requestor block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#requestor AccessPackageAssignmentPolicy#requestor}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyRequestorSettingsRequestor" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "requestor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyRequestorSettingsRequestor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Requestor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to accept requests now, when disabled, no new requests can be made using this policy.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#requests_accepted AccessPackageAssignmentPolicy#requests_accepted}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "requestsAccepted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestsAccepted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify the scopes of the requestors.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#scope_type AccessPackageAssignmentPolicy#scope_type}
        /// </remarks>
        [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScopeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccessPackageAssignmentPolicyRequestorSettings), fullyQualifiedName: "azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyRequestorSettings")]
        internal sealed class _Proxy : DeputyBase, azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyRequestorSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>requestor block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#requestor AccessPackageAssignmentPolicy#requestor}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.AccessPackageAssignmentPolicy.IAccessPackageAssignmentPolicyRequestorSettingsRequestor" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestor", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.accessPackageAssignmentPolicy.AccessPackageAssignmentPolicyRequestorSettingsRequestor\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Requestor
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether to accept requests now, when disabled, no new requests can be made using this policy.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#requests_accepted AccessPackageAssignmentPolicy#requests_accepted}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestsAccepted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RequestsAccepted
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Specify the scopes of the requestors.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/access_package_assignment_policy#scope_type AccessPackageAssignmentPolicy#scope_type}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScopeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
