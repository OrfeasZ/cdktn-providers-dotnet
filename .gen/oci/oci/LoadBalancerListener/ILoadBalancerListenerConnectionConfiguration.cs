using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerListener
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerListenerConnectionConfiguration), fullyQualifiedName: "oci.loadBalancerListener.LoadBalancerListenerConnectionConfiguration")]
    public interface ILoadBalancerListenerConnectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#idle_timeout_in_seconds LoadBalancerListener#idle_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "idleTimeoutInSeconds", typeJson: "{\"primitive\":\"string\"}")]
        string IdleTimeoutInSeconds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#backend_tcp_proxy_protocol_options LoadBalancerListener#backend_tcp_proxy_protocol_options}.</summary>
        [JsiiProperty(name: "backendTcpProxyProtocolOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? BackendTcpProxyProtocolOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#backend_tcp_proxy_protocol_version LoadBalancerListener#backend_tcp_proxy_protocol_version}.</summary>
        [JsiiProperty(name: "backendTcpProxyProtocolVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackendTcpProxyProtocolVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerListenerConnectionConfiguration), fullyQualifiedName: "oci.loadBalancerListener.LoadBalancerListenerConnectionConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerListener.ILoadBalancerListenerConnectionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#idle_timeout_in_seconds LoadBalancerListener#idle_timeout_in_seconds}.</summary>
            [JsiiProperty(name: "idleTimeoutInSeconds", typeJson: "{\"primitive\":\"string\"}")]
            public string IdleTimeoutInSeconds
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#backend_tcp_proxy_protocol_options LoadBalancerListener#backend_tcp_proxy_protocol_options}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendTcpProxyProtocolOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? BackendTcpProxyProtocolOptions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_listener#backend_tcp_proxy_protocol_version LoadBalancerListener#backend_tcp_proxy_protocol_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendTcpProxyProtocolVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackendTcpProxyProtocolVersion
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
