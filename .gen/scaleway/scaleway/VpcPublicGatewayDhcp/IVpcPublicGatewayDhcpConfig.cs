using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.VpcPublicGatewayDhcp
{
    [JsiiInterface(nativeType: typeof(IVpcPublicGatewayDhcpConfig), fullyQualifiedName: "scaleway.vpcPublicGatewayDhcp.VpcPublicGatewayDhcpConfig")]
    public interface IVpcPublicGatewayDhcpConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Subnet for the DHCP server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#subnet VpcPublicGatewayDhcp#subnet}
        /// </remarks>
        [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}")]
        string Subnet
        {
            get;
        }

        /// <summary>The address of the DHCP server.</summary>
        /// <remarks>
        /// This will be the gateway's address in the private network. Defaults to the first address of the subnet
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#address VpcPublicGatewayDhcp#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>TLD given to hostnames in the Private Network.</summary>
        /// <remarks>
        /// Allowed characters are <c>a-z0-9-.</c>. Defaults to the slugified Private Network name if created along a GatewayNetwork, or else to <c>priv</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#dns_local_name VpcPublicGatewayDhcp#dns_local_name}
        /// </remarks>
        [JsiiProperty(name: "dnsLocalName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsLocalName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Additional DNS search paths.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#dns_search VpcPublicGatewayDhcp#dns_search}
        /// </remarks>
        [JsiiProperty(name: "dnsSearch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DnsSearch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Override the DNS server list pushed to DHCP clients, instead of the gateway itself.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#dns_servers_override VpcPublicGatewayDhcp#dns_servers_override}
        /// </remarks>
        [JsiiProperty(name: "dnsServersOverride", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DnsServersOverride
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to enable dynamic pooling of IPs.</summary>
        /// <remarks>
        /// By turning the dynamic pool off, only pre-existing DHCP reservations will be handed out. Defaults to true.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#enable_dynamic VpcPublicGatewayDhcp#enable_dynamic}
        /// </remarks>
        [JsiiProperty(name: "enableDynamic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableDynamic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#id VpcPublicGatewayDhcp#id}.</summary>
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

        /// <summary>High IP (included) of the dynamic address pool. Defaults to the last address of the subnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#pool_high VpcPublicGatewayDhcp#pool_high}
        /// </remarks>
        [JsiiProperty(name: "poolHigh", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolHigh
        {
            get
            {
                return null;
            }
        }

        /// <summary>Low IP (included) of the dynamic address pool. Defaults to the second address of the subnet.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#pool_low VpcPublicGatewayDhcp#pool_low}
        /// </remarks>
        [JsiiProperty(name: "poolLow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolLow
        {
            get
            {
                return null;
            }
        }

        /// <summary>The project_id you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#project_id VpcPublicGatewayDhcp#project_id}
        /// </remarks>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the gateway should push a default route to DHCP clients or only hand out IPs. Defaults to true.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#push_default_route VpcPublicGatewayDhcp#push_default_route}
        /// </remarks>
        [JsiiProperty(name: "pushDefaultRoute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PushDefaultRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether the gateway should push custom DNS servers to clients.</summary>
        /// <remarks>
        /// This allows for instance hostname -&gt; IP resolution. Defaults to true.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#push_dns_server VpcPublicGatewayDhcp#push_dns_server}
        /// </remarks>
        [JsiiProperty(name: "pushDnsServer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PushDnsServer
        {
            get
            {
                return null;
            }
        }

        /// <summary>After how long, in seconds, a DHCP client will query for a new lease if previous renews fail.</summary>
        /// <remarks>
        /// Must be 30s lower than <c>valid_lifetime</c>. Defaults to 51m (3060s).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#rebind_timer VpcPublicGatewayDhcp#rebind_timer}
        /// </remarks>
        [JsiiProperty(name: "rebindTimer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RebindTimer
        {
            get
            {
                return null;
            }
        }

        /// <summary>After how long, in seconds, a renew will be attempted.</summary>
        /// <remarks>
        /// Must be 30s lower than <c>rebind_timer</c>. Defaults to 50m (3000s).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#renew_timer VpcPublicGatewayDhcp#renew_timer}
        /// </remarks>
        [JsiiProperty(name: "renewTimer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RenewTimer
        {
            get
            {
                return null;
            }
        }

        /// <summary>For how long, in seconds, will DHCP entries will be valid. Defaults to 1h (3600s).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#valid_lifetime VpcPublicGatewayDhcp#valid_lifetime}
        /// </remarks>
        [JsiiProperty(name: "validLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ValidLifetime
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#zone VpcPublicGatewayDhcp#zone}
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

        [JsiiTypeProxy(nativeType: typeof(IVpcPublicGatewayDhcpConfig), fullyQualifiedName: "scaleway.vpcPublicGatewayDhcp.VpcPublicGatewayDhcpConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.VpcPublicGatewayDhcp.IVpcPublicGatewayDhcpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Subnet for the DHCP server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#subnet VpcPublicGatewayDhcp#subnet}
            /// </remarks>
            [JsiiProperty(name: "subnet", typeJson: "{\"primitive\":\"string\"}")]
            public string Subnet
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The address of the DHCP server.</summary>
            /// <remarks>
            /// This will be the gateway's address in the private network. Defaults to the first address of the subnet
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#address VpcPublicGatewayDhcp#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>TLD given to hostnames in the Private Network.</summary>
            /// <remarks>
            /// Allowed characters are <c>a-z0-9-.</c>. Defaults to the slugified Private Network name if created along a GatewayNetwork, or else to <c>priv</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#dns_local_name VpcPublicGatewayDhcp#dns_local_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsLocalName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsLocalName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Additional DNS search paths.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#dns_search VpcPublicGatewayDhcp#dns_search}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsSearch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DnsSearch
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Override the DNS server list pushed to DHCP clients, instead of the gateway itself.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#dns_servers_override VpcPublicGatewayDhcp#dns_servers_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dnsServersOverride", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DnsServersOverride
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Whether to enable dynamic pooling of IPs.</summary>
            /// <remarks>
            /// By turning the dynamic pool off, only pre-existing DHCP reservations will be handed out. Defaults to true.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#enable_dynamic VpcPublicGatewayDhcp#enable_dynamic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableDynamic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableDynamic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#id VpcPublicGatewayDhcp#id}.</summary>
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

            /// <summary>High IP (included) of the dynamic address pool. Defaults to the last address of the subnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#pool_high VpcPublicGatewayDhcp#pool_high}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolHigh", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolHigh
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Low IP (included) of the dynamic address pool. Defaults to the second address of the subnet.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#pool_low VpcPublicGatewayDhcp#pool_low}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolLow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolLow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The project_id you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#project_id VpcPublicGatewayDhcp#project_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether the gateway should push a default route to DHCP clients or only hand out IPs. Defaults to true.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#push_default_route VpcPublicGatewayDhcp#push_default_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pushDefaultRoute", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PushDefaultRoute
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether the gateway should push custom DNS servers to clients.</summary>
            /// <remarks>
            /// This allows for instance hostname -&gt; IP resolution. Defaults to true.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#push_dns_server VpcPublicGatewayDhcp#push_dns_server}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pushDnsServer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PushDnsServer
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>After how long, in seconds, a DHCP client will query for a new lease if previous renews fail.</summary>
            /// <remarks>
            /// Must be 30s lower than <c>valid_lifetime</c>. Defaults to 51m (3060s).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#rebind_timer VpcPublicGatewayDhcp#rebind_timer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rebindTimer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RebindTimer
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>After how long, in seconds, a renew will be attempted.</summary>
            /// <remarks>
            /// Must be 30s lower than <c>rebind_timer</c>. Defaults to 50m (3000s).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#renew_timer VpcPublicGatewayDhcp#renew_timer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renewTimer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RenewTimer
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>For how long, in seconds, will DHCP entries will be valid. Defaults to 1h (3600s).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#valid_lifetime VpcPublicGatewayDhcp#valid_lifetime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validLifetime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ValidLifetime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/vpc_public_gateway_dhcp#zone VpcPublicGatewayDhcp#zone}
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
