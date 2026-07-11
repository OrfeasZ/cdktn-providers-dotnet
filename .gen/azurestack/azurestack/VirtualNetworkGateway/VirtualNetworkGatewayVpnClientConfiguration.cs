using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfiguration")]
    public class VirtualNetworkGatewayVpnClientConfiguration : azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#address_space VirtualNetworkGateway#address_space}.</summary>
        [JsiiProperty(name: "addressSpace", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AddressSpace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#radius_server_address VirtualNetworkGateway#radius_server_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "radiusServerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RadiusServerAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#radius_server_secret VirtualNetworkGateway#radius_server_secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "radiusServerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RadiusServerSecret
        {
            get;
            set;
        }

        private object? _revokedCertificate;

        /// <summary>revoked_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#revoked_certificate VirtualNetworkGateway#revoked_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revokedCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RevokedCertificate
        {
            get => _revokedCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _revokedCertificate = value;
            }
        }

        private object? _rootCertificate;

        /// <summary>root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#root_certificate VirtualNetworkGateway#root_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RootCertificate
        {
            get => _rootCertificate;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _rootCertificate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#vpn_client_protocols VirtualNetworkGateway#vpn_client_protocols}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpnClientProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpnClientProtocols
        {
            get;
            set;
        }
    }
}
