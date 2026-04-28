using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.LoadBalancerNetwork
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerNetworkConfig), fullyQualifiedName: "hcloud.loadBalancerNetwork.LoadBalancerNetworkConfig")]
    public interface ILoadBalancerNetworkConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the Load Balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#load_balancer_id LoadBalancerNetwork#load_balancer_id}
        /// </remarks>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"number\"}")]
        double LoadBalancerId
        {
            get;
        }

        /// <summary>Wether the Load Balancer public interface is enabled. Default is `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#enable_public_interface LoadBalancerNetwork#enable_public_interface}
        /// </remarks>
        [JsiiProperty(name: "enablePublicInterface", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnablePublicInterface
        {
            get
            {
                return null;
            }
        }

        /// <summary>IP to assign to the Load Balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#ip LoadBalancerNetwork#ip}
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

        /// <summary>ID of the Network to attach the Load Balancer to.</summary>
        /// <remarks>
        /// Using <c>subnet_id</c> is preferred. Required if <c>subnet_id</c> is not set. If <c>subnet_id</c> or <c>ip</c> are not set, the Load Balancer will be attached to the last subnet (ordered by <c>ip_range</c>).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#network_id LoadBalancerNetwork#network_id}
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

        /// <summary>ID of the Subnet to attach the Load Balancer to. Required if `network_id` is not set.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#subnet_id LoadBalancerNetwork#subnet_id}
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

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerNetworkConfig), fullyQualifiedName: "hcloud.loadBalancerNetwork.LoadBalancerNetworkConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.LoadBalancerNetwork.ILoadBalancerNetworkConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the Load Balancer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#load_balancer_id LoadBalancerNetwork#load_balancer_id}
            /// </remarks>
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"number\"}")]
            public double LoadBalancerId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Wether the Load Balancer public interface is enabled. Default is `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#enable_public_interface LoadBalancerNetwork#enable_public_interface}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enablePublicInterface", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnablePublicInterface
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>IP to assign to the Load Balancer.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#ip LoadBalancerNetwork#ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the Network to attach the Load Balancer to.</summary>
            /// <remarks>
            /// Using <c>subnet_id</c> is preferred. Required if <c>subnet_id</c> is not set. If <c>subnet_id</c> or <c>ip</c> are not set, the Load Balancer will be attached to the last subnet (ordered by <c>ip_range</c>).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#network_id LoadBalancerNetwork#network_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NetworkId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ID of the Subnet to attach the Load Balancer to. Required if `network_id` is not set.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.62.0/docs/resources/load_balancer_network#subnet_id LoadBalancerNetwork#subnet_id}
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
