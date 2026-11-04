using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerScope
{
    [JsiiInterface(nativeType: typeof(INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr), fullyQualifiedName: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr")]
    public interface INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr
    {
        /// <summary>alb_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#alb_config NetworksecuritymanagerScope#alb_config}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOrAlbConfig" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "albConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOrAlbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AlbConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#tags NetworksecuritymanagerScope#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr), fullyQualifiedName: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr")]
        internal sealed class _Proxy : DeputyBase, aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>alb_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#alb_config NetworksecuritymanagerScope#alb_config}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOrAlbConfig" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "albConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOrAlbConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AlbConfig
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#tags NetworksecuritymanagerScope#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
