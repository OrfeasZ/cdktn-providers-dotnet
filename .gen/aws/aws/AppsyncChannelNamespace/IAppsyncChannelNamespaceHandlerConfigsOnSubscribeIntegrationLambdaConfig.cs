using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiInterface(nativeType: typeof(IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig")]
    public interface IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#invoke_type AppsyncChannelNamespace#invoke_type}.</summary>
        [JsiiProperty(name: "invokeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InvokeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#invoke_type AppsyncChannelNamespace#invoke_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "invokeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InvokeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
