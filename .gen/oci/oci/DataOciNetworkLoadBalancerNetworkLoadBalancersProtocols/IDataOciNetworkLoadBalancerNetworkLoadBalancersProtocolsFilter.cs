using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciNetworkLoadBalancerNetworkLoadBalancersProtocols
{
    [JsiiInterface(nativeType: typeof(IDataOciNetworkLoadBalancerNetworkLoadBalancersProtocolsFilter), fullyQualifiedName: "oci.dataOciNetworkLoadBalancerNetworkLoadBalancersProtocols.DataOciNetworkLoadBalancerNetworkLoadBalancersProtocolsFilter")]
    public interface IDataOciNetworkLoadBalancerNetworkLoadBalancersProtocolsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancers_protocols#name DataOciNetworkLoadBalancerNetworkLoadBalancersProtocols#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancers_protocols#values DataOciNetworkLoadBalancerNetworkLoadBalancersProtocols#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancers_protocols#regex DataOciNetworkLoadBalancerNetworkLoadBalancersProtocols#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciNetworkLoadBalancerNetworkLoadBalancersProtocolsFilter), fullyQualifiedName: "oci.dataOciNetworkLoadBalancerNetworkLoadBalancersProtocols.DataOciNetworkLoadBalancerNetworkLoadBalancersProtocolsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciNetworkLoadBalancerNetworkLoadBalancersProtocols.IDataOciNetworkLoadBalancerNetworkLoadBalancersProtocolsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancers_protocols#name DataOciNetworkLoadBalancerNetworkLoadBalancersProtocols#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancers_protocols#values DataOciNetworkLoadBalancerNetworkLoadBalancersProtocols#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/network_load_balancer_network_load_balancers_protocols#regex DataOciNetworkLoadBalancerNetworkLoadBalancersProtocols#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
