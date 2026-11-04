using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerScope
{
    [JsiiByValue(fqn: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfiguration")]
    public class NetworksecuritymanagerScopeScopeConfiguration : aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfiguration
    {
        private object? _accountFilter;

        /// <summary>account_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#account_filter NetworksecuritymanagerScope#account_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationAccountFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationAccountFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AccountFilter
        {
            get => _accountFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationAccountFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationAccountFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _accountFilter = value;
            }
        }

        private object? _resourceScope;

        /// <summary>resource_scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#resource_scope NetworksecuritymanagerScope#resource_scope}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScope" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceScope", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScope\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResourceScope
        {
            get => _resourceScope;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScope[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScope).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceScope = value;
            }
        }
    }
}
