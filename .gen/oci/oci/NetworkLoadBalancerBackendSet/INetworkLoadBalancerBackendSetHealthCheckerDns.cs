using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkLoadBalancerBackendSet
{
    [JsiiInterface(nativeType: typeof(INetworkLoadBalancerBackendSetHealthCheckerDns), fullyQualifiedName: "oci.networkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerDns")]
    public interface INetworkLoadBalancerBackendSetHealthCheckerDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#domain_name NetworkLoadBalancerBackendSet#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        string DomainName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#query_class NetworkLoadBalancerBackendSet#query_class}.</summary>
        [JsiiProperty(name: "queryClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryClass
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#query_type NetworkLoadBalancerBackendSet#query_type}.</summary>
        [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#rcodes NetworkLoadBalancerBackendSet#rcodes}.</summary>
        [JsiiProperty(name: "rcodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Rcodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#transport_protocol NetworkLoadBalancerBackendSet#transport_protocol}.</summary>
        [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TransportProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkLoadBalancerBackendSetHealthCheckerDns), fullyQualifiedName: "oci.networkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerDns")]
        internal sealed class _Proxy : DeputyBase, oci.NetworkLoadBalancerBackendSet.INetworkLoadBalancerBackendSetHealthCheckerDns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#domain_name NetworkLoadBalancerBackendSet#domain_name}.</summary>
            [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
            public string DomainName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#query_class NetworkLoadBalancerBackendSet#query_class}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryClass
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#query_type NetworkLoadBalancerBackendSet#query_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#rcodes NetworkLoadBalancerBackendSet#rcodes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "rcodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Rcodes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#transport_protocol NetworkLoadBalancerBackendSet#transport_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TransportProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
