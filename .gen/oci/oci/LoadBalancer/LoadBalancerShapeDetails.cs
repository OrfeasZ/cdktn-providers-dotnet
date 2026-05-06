using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loadBalancer.LoadBalancerShapeDetails")]
    public class LoadBalancerShapeDetails : oci.LoadBalancer.ILoadBalancerShapeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer#maximum_bandwidth_in_mbps LoadBalancer#maximum_bandwidth_in_mbps}.</summary>
        [JsiiProperty(name: "maximumBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public double MaximumBandwidthInMbps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer#minimum_bandwidth_in_mbps LoadBalancer#minimum_bandwidth_in_mbps}.</summary>
        [JsiiProperty(name: "minimumBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        public double MinimumBandwidthInMbps
        {
            get;
            set;
        }
    }
}
