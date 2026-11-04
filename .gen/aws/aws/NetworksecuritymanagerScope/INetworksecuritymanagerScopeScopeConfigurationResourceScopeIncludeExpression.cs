using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerScope
{
    [JsiiInterface(nativeType: typeof(INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpression), fullyQualifiedName: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpression")]
    public interface INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpression
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#and NetworksecuritymanagerScope#and}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionAnd" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? And
        {
            get
            {
                return null;
            }
        }

        /// <summary>criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#criteria NetworksecuritymanagerScope#criteria}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionCriteria" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "criteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Criteria
        {
            get
            {
                return null;
            }
        }

        /// <summary>not block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#not NetworksecuritymanagerScope#not}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionNot" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "not", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionNot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Not
        {
            get
            {
                return null;
            }
        }

        /// <summary>or block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#or NetworksecuritymanagerScope#or}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Or
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpression), fullyQualifiedName: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpression")]
        internal sealed class _Proxy : DeputyBase, aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#and NetworksecuritymanagerScope#and}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionAnd" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "and", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionAnd\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? And
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#criteria NetworksecuritymanagerScope#criteria}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionCriteria" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "criteria", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionCriteria\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Criteria
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>not block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#not NetworksecuritymanagerScope#not}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionNot" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "not", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionNot\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Not
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>or block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#or NetworksecuritymanagerScope#or}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "or", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationResourceScopeIncludeExpressionOr\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Or
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
