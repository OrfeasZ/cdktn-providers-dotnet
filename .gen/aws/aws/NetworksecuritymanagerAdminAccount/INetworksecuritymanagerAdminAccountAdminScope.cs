using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerAdminAccount
{
    [JsiiInterface(nativeType: typeof(INetworksecuritymanagerAdminAccountAdminScope), fullyQualifiedName: "aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScope")]
    public interface INetworksecuritymanagerAdminAccountAdminScope
    {
        /// <summary>firewall_type_scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_admin_account#firewall_type_scope NetworksecuritymanagerAdminAccount#firewall_type_scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeFirewallTypeScope" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "firewallTypeScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScopeFirewallTypeScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FirewallTypeScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>scope_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_admin_account#scope_filter NetworksecuritymanagerAdminAccount#scope_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeScopeFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "scopeFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScopeScopeFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScopeFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworksecuritymanagerAdminAccountAdminScope), fullyQualifiedName: "aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScope")]
        internal sealed class _Proxy : DeputyBase, aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScope
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>firewall_type_scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_admin_account#firewall_type_scope NetworksecuritymanagerAdminAccount#firewall_type_scope}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeFirewallTypeScope" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "firewallTypeScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScopeFirewallTypeScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FirewallTypeScope
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>scope_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_admin_account#scope_filter NetworksecuritymanagerAdminAccount#scope_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeScopeFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopeFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScopeScopeFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScopeFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
