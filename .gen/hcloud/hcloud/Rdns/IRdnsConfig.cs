using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.Rdns
{
    [JsiiInterface(nativeType: typeof(IRdnsConfig), fullyQualifiedName: "hcloud.rdns.RdnsConfig")]
    public interface IRdnsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Domain name `ip_address` should point to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#dns_ptr Rdns#dns_ptr}
        /// </remarks>
        [JsiiProperty(name: "dnsPtr", typeJson: "{\"primitive\":\"string\"}")]
        string DnsPtr
        {
            get;
        }

        /// <summary>IP address that should point to `dns_ptr`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#ip_address Rdns#ip_address}
        /// </remarks>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        string IpAddress
        {
            get;
        }

        /// <summary>ID of the Floating IP the `ip_address` belongs to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#floating_ip_id Rdns#floating_ip_id}
        /// </remarks>
        [JsiiProperty(name: "floatingIpId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FloatingIpId
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the Load Balancer the `ip_address` belongs to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#load_balancer_id Rdns#load_balancer_id}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LoadBalancerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the Primary IP the `ip_address` belongs to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#primary_ip_id Rdns#primary_ip_id}
        /// </remarks>
        [JsiiProperty(name: "primaryIpId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PrimaryIpId
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the Server the `ip_address` belongs to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#server_id Rdns#server_id}
        /// </remarks>
        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ServerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdnsConfig), fullyQualifiedName: "hcloud.rdns.RdnsConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.Rdns.IRdnsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Domain name `ip_address` should point to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#dns_ptr Rdns#dns_ptr}
            /// </remarks>
            [JsiiProperty(name: "dnsPtr", typeJson: "{\"primitive\":\"string\"}")]
            public string DnsPtr
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>IP address that should point to `dns_ptr`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#ip_address Rdns#ip_address}
            /// </remarks>
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ID of the Floating IP the `ip_address` belongs to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#floating_ip_id Rdns#floating_ip_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "floatingIpId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FloatingIpId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ID of the Load Balancer the `ip_address` belongs to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#load_balancer_id Rdns#load_balancer_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LoadBalancerId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ID of the Primary IP the `ip_address` belongs to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#primary_ip_id Rdns#primary_ip_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "primaryIpId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PrimaryIpId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ID of the Server the `ip_address` belongs to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.64.0/docs/resources/rdns#server_id Rdns#server_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ServerId
            {
                get => GetInstanceProperty<double?>();
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
