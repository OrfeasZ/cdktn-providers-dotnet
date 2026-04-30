using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublish")]
    public class AppsyncChannelNamespaceHandlerConfigsOnPublish : aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublish
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_channel_namespace#behavior AppsyncChannelNamespace#behavior}.</summary>
        [JsiiProperty(name: "behavior", typeJson: "{\"primitive\":\"string\"}")]
        public string Behavior
        {
            get;
            set;
        }

        private object? _integration;

        /// <summary>integration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_channel_namespace#integration AppsyncChannelNamespace#integration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "integration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnPublishIntegration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Integration
        {
            get => _integration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublishIntegration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnPublishIntegration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _integration = value;
            }
        }
    }
}
