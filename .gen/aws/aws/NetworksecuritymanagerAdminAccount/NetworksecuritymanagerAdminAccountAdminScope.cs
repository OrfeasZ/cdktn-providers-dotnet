using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerAdminAccount
{
    [JsiiByValue(fqn: "aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScope")]
    public class NetworksecuritymanagerAdminAccountAdminScope : aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScope
    {
        private object? _firewallTypeScope;

        /// <summary>firewall_type_scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_admin_account#firewall_type_scope NetworksecuritymanagerAdminAccount#firewall_type_scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeFirewallTypeScope" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "firewallTypeScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScopeFirewallTypeScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FirewallTypeScope
        {
            get => _firewallTypeScope;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeFirewallTypeScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeFirewallTypeScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _firewallTypeScope = value;
            }
        }

        private object? _scopeFilter;

        /// <summary>scope_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/networksecuritymanager_admin_account#scope_filter NetworksecuritymanagerAdminAccount#scope_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeScopeFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopeFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerAdminAccount.NetworksecuritymanagerAdminAccountAdminScopeScopeFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ScopeFilter
        {
            get => _scopeFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeScopeFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerAdminAccount.INetworksecuritymanagerAdminAccountAdminScopeScopeFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _scopeFilter = value;
            }
        }
    }
}
