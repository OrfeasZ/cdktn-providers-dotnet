using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ConnectivityDirectoryService
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetwork")]
    public class ConnectivityDirectoryServiceHostResolverNetwork : cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostResolverNetwork
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#tunnel_id ConnectivityDirectoryService#tunnel_id}.</summary>
        [JsiiProperty(name: "tunnelId", typeJson: "{\"primitive\":\"string\"}")]
        public string TunnelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#resolver_ips ConnectivityDirectoryService#resolver_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resolverIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ResolverIps
        {
            get;
            set;
        }
    }
}
