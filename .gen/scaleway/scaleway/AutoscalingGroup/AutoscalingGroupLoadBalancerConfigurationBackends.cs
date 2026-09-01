using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.autoscalingGroup.AutoscalingGroupLoadBalancerConfigurationBackends")]
    public class AutoscalingGroupLoadBalancerConfigurationBackends : scaleway.AutoscalingGroup.IAutoscalingGroupLoadBalancerConfigurationBackends
    {
        /// <summary>The IP address family (IPv4 or IPv6).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#address_family AutoscalingGroup#address_family}
        /// </remarks>
        [JsiiProperty(name: "addressFamily", typeJson: "{\"primitive\":\"string\"}")]
        public string AddressFamily
        {
            get;
            set;
        }

        /// <summary>The ID of the load balancer backend.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#backend_id AutoscalingGroup#backend_id}
        /// </remarks>
        [JsiiProperty(name: "backendId", typeJson: "{\"primitive\":\"string\"}")]
        public string BackendId
        {
            get;
            set;
        }

        /// <summary>The ID of the private network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/autoscaling_group#private_network_id AutoscalingGroup#private_network_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateNetworkId
        {
            get;
            set;
        }
    }
}
