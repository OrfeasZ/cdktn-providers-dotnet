using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceSubscribeAuthMode")]
    public class AppsyncChannelNamespaceSubscribeAuthMode : aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceSubscribeAuthMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/appsync_channel_namespace#auth_type AppsyncChannelNamespace#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthType
        {
            get;
            set;
        }
    }
}
