using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncChannelNamespace
{
    [JsiiInterface(nativeType: typeof(IAppsyncChannelNamespaceSubscribeAuthMode), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceSubscribeAuthMode")]
    public interface IAppsyncChannelNamespaceSubscribeAuthMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_channel_namespace#auth_type AppsyncChannelNamespace#auth_type}.</summary>
        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        string AuthType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncChannelNamespaceSubscribeAuthMode), fullyQualifiedName: "aws.appsyncChannelNamespace.AppsyncChannelNamespaceSubscribeAuthMode")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncChannelNamespace.IAppsyncChannelNamespaceSubscribeAuthMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/appsync_channel_namespace#auth_type AppsyncChannelNamespace#auth_type}.</summary>
            [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
