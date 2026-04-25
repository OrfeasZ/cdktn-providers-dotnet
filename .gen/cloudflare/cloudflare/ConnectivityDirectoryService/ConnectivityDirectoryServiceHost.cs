using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ConnectivityDirectoryService
{
    [JsiiByValue(fqn: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHost")]
    public class ConnectivityDirectoryServiceHost : cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHost
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#hostname ConnectivityDirectoryService#hostname}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Hostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#ipv4 ConnectivityDirectoryService#ipv4}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv4
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#ipv6 ConnectivityDirectoryService#ipv6}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ipv6
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#network ConnectivityDirectoryService#network}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetwork\"}", isOptional: true)]
        public cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostNetwork? Network
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/connectivity_directory_service#resolver_network ConnectivityDirectoryService#resolver_network}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resolverNetwork", typeJson: "{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetwork\"}", isOptional: true)]
        public cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostResolverNetwork? ResolverNetwork
        {
            get;
            set;
        }
    }
}
