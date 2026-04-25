using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ConnectivityDirectoryService
{
    [JsiiInterface(nativeType: typeof(IConnectivityDirectoryServiceHostResolverNetwork), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetwork")]
    public interface IConnectivityDirectoryServiceHostResolverNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#tunnel_id ConnectivityDirectoryService#tunnel_id}.</summary>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
        string TunnelId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#resolver_ips ConnectivityDirectoryService#resolver_ips}.</summary>
        [JsiiProperty(name: "resolverIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResolverIps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectivityDirectoryServiceHostResolverNetwork), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetwork")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostResolverNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#tunnel_id ConnectivityDirectoryService#tunnel_id}.</summary>
            [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
            public string TunnelId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#resolver_ips ConnectivityDirectoryService#resolver_ips}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resolverIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResolverIps
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
