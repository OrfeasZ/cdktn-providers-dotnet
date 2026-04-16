using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration")]
    public class AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration : aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_channel_namespace#data_source_name AppsyncChannelNamespace#data_source_name}.</summary>
        [JsiiProperty(name: "dataSourceName", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSourceName
        {
            get;
            set;
        }

        private object? _lambdaConfig;

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_channel_namespace#lambda_config AppsyncChannelNamespace#lambda_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LambdaConfig
        {
            get => _lambdaConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lambdaConfig = value;
            }
        }
    }
}
