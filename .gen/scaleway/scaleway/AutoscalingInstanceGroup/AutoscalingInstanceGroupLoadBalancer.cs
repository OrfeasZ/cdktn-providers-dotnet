using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.AutoscalingInstanceGroup
{
    [JsiiByValue(fqn: "scaleway.autoscalingInstanceGroup.AutoscalingInstanceGroupLoadBalancer")]
    public class AutoscalingInstanceGroupLoadBalancer : scaleway.AutoscalingInstanceGroup.IAutoscalingInstanceGroupLoadBalancer
    {
        /// <summary>The Load Balancer backend IDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#backend_ids AutoscalingInstanceGroup#backend_ids}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backendIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BackendIds
        {
            get;
            set;
        }

        /// <summary>The ID of the load balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#id AutoscalingInstanceGroup#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>The ID of the Private Network attached to the Load Balancer.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/autoscaling_instance_group#private_network_id AutoscalingInstanceGroup#private_network_id}
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
