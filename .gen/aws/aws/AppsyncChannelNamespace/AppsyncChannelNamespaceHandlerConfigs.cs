using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiByValue(fqn: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigs")]
    public class AppsyncChannelNamespaceHandlerConfigs : aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigs
    {
        private object? _onPublish;

        /// <summary>on_publish block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#on_publish AppsyncChannelNamespace#on_publish}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onPublish", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublish\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OnPublish
        {
            get => _onPublish;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublish[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublish).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _onPublish = value;
            }
        }

        private object? _onSubscribe;

        /// <summary>on_subscribe block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#on_subscribe AppsyncChannelNamespace#on_subscribe}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onSubscribe", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribe\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OnSubscribe
        {
            get => _onSubscribe;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribe[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribe).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _onSubscribe = value;
            }
        }
    }
}
