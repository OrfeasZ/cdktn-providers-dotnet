using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiInterface(nativeType: typeof(IAppsyncChannelNamespaceHandlerConfigsOnSubscribe), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribe")]
    public interface IAppsyncChannelNamespaceHandlerConfigsOnSubscribe
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#behavior AppsyncChannelNamespace#behavior}.</summary>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        string Behavior
        {
            get;
        }

        /// <summary>integration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#integration AppsyncChannelNamespace#integration}
        /// </remarks>
        [JsiiProperty(name: "integration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Integration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncChannelNamespaceHandlerConfigsOnSubscribe), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribe")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribe
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#behavior AppsyncChannelNamespace#behavior}.</summary>
            [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
            public string Behavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>integration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#integration AppsyncChannelNamespace#integration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "integration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Integration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
