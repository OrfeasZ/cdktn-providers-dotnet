using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.NetworkLoadBalancerBackendSet
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.networkLoadBalancerBackendSet.NetworkLoadBalancerBackendSetHealthCheckerDns")]
    public class NetworkLoadBalancerBackendSetHealthCheckerDns : oci.NetworkLoadBalancerBackendSet.INetworkLoadBalancerBackendSetHealthCheckerDns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#domain_name NetworkLoadBalancerBackendSet#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#query_class NetworkLoadBalancerBackendSet#query_class}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryClass", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#query_type NetworkLoadBalancerBackendSet#query_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#rcodes NetworkLoadBalancerBackendSet#rcodes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rcodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Rcodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/network_load_balancer_backend_set#transport_protocol NetworkLoadBalancerBackendSet#transport_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transportProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransportProtocol
        {
            get;
            set;
        }
    }
}
