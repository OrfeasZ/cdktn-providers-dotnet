using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ConnectivityDirectoryService
{
    [JsiiInterface(nativeType: typeof(IConnectivityDirectoryServiceHostNetwork), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetwork")]
    public interface IConnectivityDirectoryServiceHostNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#tunnel_id ConnectivityDirectoryService#tunnel_id}.</summary>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
        string TunnelId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectivityDirectoryServiceHostNetwork), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetwork")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#tunnel_id ConnectivityDirectoryService#tunnel_id}.</summary>
            [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
            public string TunnelId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
