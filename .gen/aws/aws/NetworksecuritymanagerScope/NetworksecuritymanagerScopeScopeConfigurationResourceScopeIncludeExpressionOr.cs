using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerScope
{
    [JsiiByValue(fqn: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr")]
    public class NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr : aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr
    {
        private object? _albConfig;

        /// <summary>alb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#alb_config NetworksecuritymanagerScope#alb_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOrAlbConfig" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "albConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOrAlbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AlbConfig
        {
            get => _albConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOrAlbConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOrAlbConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _albConfig = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#tags NetworksecuritymanagerScope#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }
    }
}
