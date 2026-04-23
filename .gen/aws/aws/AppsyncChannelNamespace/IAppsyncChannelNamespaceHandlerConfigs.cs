using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiInterface(nativeType: typeof(IAppsyncChannelNamespaceHandlerConfigs), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigs")]
    public interface IAppsyncChannelNamespaceHandlerConfigs
    {
        /// <summary>on_publish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#on_publish AppsyncChannelNamespace#on_publish}
        /// </remarks>
        [JsiiProperty(name: "onPublish", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublish\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnPublish
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_subscribe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#on_subscribe AppsyncChannelNamespace#on_subscribe}
        /// </remarks>
        [JsiiProperty(name: "onSubscribe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnSubscribe
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncChannelNamespaceHandlerConfigs), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigs")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>on_publish block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#on_publish AppsyncChannelNamespace#on_publish}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onPublish", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublish\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OnPublish
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>on_subscribe block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#on_subscribe AppsyncChannelNamespace#on_subscribe}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onSubscribe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? OnSubscribe
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
