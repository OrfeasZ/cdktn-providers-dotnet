using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncChannelNamespace.AppsyncChannelNamespacePublishAuthMode")]
    public class AppsyncChannelNamespacePublishAuthMode : aws.AppsyncChannelNamespace.IAppsyncChannelNamespacePublishAuthMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/appsync_channel_namespace#auth_type AppsyncChannelNamespace#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthType
        {
            get;
            set;
        }
    }
}
