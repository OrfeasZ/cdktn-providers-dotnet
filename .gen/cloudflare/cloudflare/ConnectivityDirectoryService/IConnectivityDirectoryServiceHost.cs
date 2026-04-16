using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ConnectivityDirectoryService
{
    [JsiiInterface(nativeType: typeof(IConnectivityDirectoryServiceHost), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHost")]
    public interface IConnectivityDirectoryServiceHost
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#hostname ConnectivityDirectoryService#hostname}.</summary>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#ipv4 ConnectivityDirectoryService#ipv4}.</summary>
        [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv4
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#ipv6 ConnectivityDirectoryService#ipv6}.</summary>
        [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ipv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#network ConnectivityDirectoryService#network}.</summary>
        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostNetwork? Network
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#resolver_network ConnectivityDirectoryService#resolver_network}.</summary>
        [JsiiProperty(name: "resolverNetwork", typeJson: "{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetwork\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostResolverNetwork? ResolverNetwork
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectivityDirectoryServiceHost), fullyQualifiedName: "cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHost")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#hostname ConnectivityDirectoryService#hostname}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hostname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#ipv4 ConnectivityDirectoryService#ipv4}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv4
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#ipv6 ConnectivityDirectoryService#ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ipv6
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#network ConnectivityDirectoryService#network}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostNetwork\"}", isOptional: true)]
            public cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostNetwork? Network
            {
                get => GetInstanceProperty<cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostNetwork?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/connectivity_directory_service#resolver_network ConnectivityDirectoryService#resolver_network}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resolverNetwork", typeJson: "{\"fqn\":\"cloudflare.connectivityDirectoryService.ConnectivityDirectoryServiceHostResolverNetwork\"}", isOptional: true)]
            public cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostResolverNetwork? ResolverNetwork
            {
                get => GetInstanceProperty<cloudflare.ConnectivityDirectoryService.IConnectivityDirectoryServiceHostResolverNetwork?>();
            }
        }
    }
}
