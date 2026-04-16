using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPublicGatewayDhcpReservation
{
    [JsiiInterface(nativeType: typeof(IVpcPublicGatewayDhcpReservationConfig), fullyQualifiedName: "scaleway.vpcPublicGatewayDhcpReservation.VpcPublicGatewayDhcpReservationConfig")]
    public interface IVpcPublicGatewayDhcpReservationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the owning GatewayNetwork (UUID format).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#gateway_network_id VpcPublicGatewayDhcpReservation#gateway_network_id}
        /// </remarks>
        [JsiiProperty(name: "gatewayNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string GatewayNetworkId
        {
            get;
        }

        /// <summary>The IP address to give to the machine (IPv4 address).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#ip_address VpcPublicGatewayDhcpReservation#ip_address}
        /// </remarks>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        string IpAddress
        {
            get;
        }

        /// <summary>The MAC address to give a static entry to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#mac_address VpcPublicGatewayDhcpReservation#mac_address}
        /// </remarks>
        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
        string MacAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#id VpcPublicGatewayDhcpReservation#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#timeouts VpcPublicGatewayDhcpReservation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.vpcPublicGatewayDhcpReservation.VpcPublicGatewayDhcpReservationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.VpcPublicGatewayDhcpReservation.IVpcPublicGatewayDhcpReservationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#zone VpcPublicGatewayDhcpReservation#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcPublicGatewayDhcpReservationConfig), fullyQualifiedName: "scaleway.vpcPublicGatewayDhcpReservation.VpcPublicGatewayDhcpReservationConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.VpcPublicGatewayDhcpReservation.IVpcPublicGatewayDhcpReservationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the owning GatewayNetwork (UUID format).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#gateway_network_id VpcPublicGatewayDhcpReservation#gateway_network_id}
            /// </remarks>
            [JsiiProperty(name: "gatewayNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string GatewayNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The IP address to give to the machine (IPv4 address).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#ip_address VpcPublicGatewayDhcpReservation#ip_address}
            /// </remarks>
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The MAC address to give a static entry to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#mac_address VpcPublicGatewayDhcpReservation#mac_address}
            /// </remarks>
            [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string MacAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#id VpcPublicGatewayDhcpReservation#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#timeouts VpcPublicGatewayDhcpReservation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.vpcPublicGatewayDhcpReservation.VpcPublicGatewayDhcpReservationTimeouts\"}", isOptional: true)]
            public scaleway.VpcPublicGatewayDhcpReservation.IVpcPublicGatewayDhcpReservationTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.VpcPublicGatewayDhcpReservation.IVpcPublicGatewayDhcpReservationTimeouts?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp_reservation#zone VpcPublicGatewayDhcpReservation#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
