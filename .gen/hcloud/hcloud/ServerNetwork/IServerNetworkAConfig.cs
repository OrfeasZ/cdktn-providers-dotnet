using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.ServerNetwork
{
    [JsiiInterface(nativeType: typeof(IServerNetworkAConfig), fullyQualifiedName: "hcloud.serverNetwork.ServerNetworkAConfig")]
    public interface IServerNetworkAConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#server_id ServerNetworkA#server_id}
        /// </remarks>
        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"number\"}")]
        double ServerId
        {
            get;
        }

        /// <summary>Additional IPs to assign to the Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#alias_ips ServerNetworkA#alias_ips}
        /// </remarks>
        [JsiiProperty(name: "aliasIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AliasIps
        {
            get
            {
                return null;
            }
        }

        /// <summary>IP to assign to the Server.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#ip ServerNetworkA#ip}
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the Network to attach the Server to.</summary>
        /// <remarks>
        /// Using <c>subnet_id</c> is preferred. Required if <c>subnet_id</c> is not set. If <c>subnet_id</c> or <c>ip</c> are not set, the Server will be attached to the last subnet (ordered by <c>ip_range</c>).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#network_id ServerNetworkA#network_id}
        /// </remarks>
        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the Subnet to attach the Server to. Required if `network_id` is not set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#subnet_id ServerNetworkA#subnet_id}
        /// </remarks>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServerNetworkAConfig), fullyQualifiedName: "hcloud.serverNetwork.ServerNetworkAConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.ServerNetwork.IServerNetworkAConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#server_id ServerNetworkA#server_id}
            /// </remarks>
            [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"number\"}")]
            public double ServerId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Additional IPs to assign to the Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#alias_ips ServerNetworkA#alias_ips}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aliasIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AliasIps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>IP to assign to the Server.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#ip ServerNetworkA#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the Network to attach the Server to.</summary>
            /// <remarks>
            /// Using <c>subnet_id</c> is preferred. Required if <c>subnet_id</c> is not set. If <c>subnet_id</c> or <c>ip</c> are not set, the Server will be attached to the last subnet (ordered by <c>ip_range</c>).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#network_id ServerNetworkA#network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NetworkId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ID of the Subnet to attach the Server to. Required if `network_id` is not set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/server_network#subnet_id ServerNetworkA#subnet_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
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
