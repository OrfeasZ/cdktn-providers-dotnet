using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiInterface(nativeType: typeof(IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration")]
    public interface IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_channel_namespace#data_source_name AppsyncChannelNamespace#data_source_name}.</summary>
        [JsiiProperty(name: "dataSourceName", typeJson: "{\"primitive\":\"string\"}")]
        string DataSourceName
        {
            get;
        }

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_channel_namespace#lambda_config AppsyncChannelNamespace#lambda_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LambdaConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_channel_namespace#data_source_name AppsyncChannelNamespace#data_source_name}.</summary>
            [JsiiProperty(name: "dataSourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSourceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>lambda_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_channel_namespace#lambda_config AppsyncChannelNamespace#lambda_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LambdaConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
