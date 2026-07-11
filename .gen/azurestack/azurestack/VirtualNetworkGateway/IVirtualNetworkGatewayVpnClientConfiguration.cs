using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.VirtualNetworkGateway
{
    [JsiiInterface(nativeType: typeof(IVirtualNetworkGatewayVpnClientConfiguration), fullyQualifiedName: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfiguration")]
    public interface IVirtualNetworkGatewayVpnClientConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#address_space VirtualNetworkGateway#address_space}.</summary>
        [JsiiProperty(name: "addressSpace", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AddressSpace
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#radius_server_address VirtualNetworkGateway#radius_server_address}.</summary>
        [JsiiProperty(name: "radiusServerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RadiusServerAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#radius_server_secret VirtualNetworkGateway#radius_server_secret}.</summary>
        [JsiiProperty(name: "radiusServerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RadiusServerSecret
        {
            get
            {
                return null;
            }
        }

        /// <summary>revoked_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#revoked_certificate VirtualNetworkGateway#revoked_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "revokedCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RevokedCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>root_certificate block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#root_certificate VirtualNetworkGateway#root_certificate}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "rootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RootCertificate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#vpn_client_protocols VirtualNetworkGateway#vpn_client_protocols}.</summary>
        [JsiiProperty(name: "vpnClientProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpnClientProtocols
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualNetworkGatewayVpnClientConfiguration), fullyQualifiedName: "azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#address_space VirtualNetworkGateway#address_space}.</summary>
            [JsiiProperty(name: "addressSpace", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AddressSpace
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#radius_server_address VirtualNetworkGateway#radius_server_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "radiusServerAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RadiusServerAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#radius_server_secret VirtualNetworkGateway#radius_server_secret}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "radiusServerSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RadiusServerSecret
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>revoked_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#revoked_certificate VirtualNetworkGateway#revoked_certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "revokedCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RevokedCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>root_certificate block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#root_certificate VirtualNetworkGateway#root_certificate}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurestack.VirtualNetworkGateway.IVirtualNetworkGatewayVpnClientConfigurationRootCertificate" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rootCertificate", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurestack.virtualNetworkGateway.VirtualNetworkGatewayVpnClientConfigurationRootCertificate\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RootCertificate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurestack/1.0.0/docs/resources/virtual_network_gateway#vpn_client_protocols VirtualNetworkGateway#vpn_client_protocols}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpnClientProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpnClientProtocols
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
