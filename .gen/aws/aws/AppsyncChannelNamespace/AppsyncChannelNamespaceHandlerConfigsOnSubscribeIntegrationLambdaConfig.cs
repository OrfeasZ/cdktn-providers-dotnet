using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiByValue(fqn: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig")]
    public class AppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig : aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceHandlerConfigsOnSubscribeIntegrationLambdaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#invoke_type AppsyncChannelNamespace#invoke_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "invokeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InvokeType
        {
            get;
            set;
        }
    }
}
