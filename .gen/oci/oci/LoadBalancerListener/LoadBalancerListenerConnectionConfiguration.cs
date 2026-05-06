using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerListener
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loadBalancerListener.LoadBalancerListenerConnectionConfiguration")]
    public class LoadBalancerListenerConnectionConfiguration : oci.LoadBalancerListener.ILoadBalancerListenerConnectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#idle_timeout_in_seconds LoadBalancerListener#idle_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "idleTimeoutInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        public string IdleTimeoutInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#backend_tcp_proxy_protocol_options LoadBalancerListener#backend_tcp_proxy_protocol_options}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendTcpProxyProtocolOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BackendTcpProxyProtocolOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#backend_tcp_proxy_protocol_version LoadBalancerListener#backend_tcp_proxy_protocol_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendTcpProxyProtocolVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackendTcpProxyProtocolVersion
        {
            get;
            set;
        }
    }
}
