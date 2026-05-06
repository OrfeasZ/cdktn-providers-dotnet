using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerLoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerLoadBalancerShapeDetails), fullyQualifiedName: "oci.loadBalancerLoadBalancer.LoadBalancerLoadBalancerShapeDetails")]
    public interface ILoadBalancerLoadBalancerShapeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer#maximum_bandwidth_in_mbps LoadBalancerLoadBalancer#maximum_bandwidth_in_mbps}.</summary>
        [JsiiProperty(name: "maximumBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        double MaximumBandwidthInMbps
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer#minimum_bandwidth_in_mbps LoadBalancerLoadBalancer#minimum_bandwidth_in_mbps}.</summary>
        [JsiiProperty(name: "minimumBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
        double MinimumBandwidthInMbps
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerLoadBalancerShapeDetails), fullyQualifiedName: "oci.loadBalancerLoadBalancer.LoadBalancerLoadBalancerShapeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerLoadBalancer.ILoadBalancerLoadBalancerShapeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer#maximum_bandwidth_in_mbps LoadBalancerLoadBalancer#maximum_bandwidth_in_mbps}.</summary>
            [JsiiProperty(name: "maximumBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
            public double MaximumBandwidthInMbps
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_load_balancer#minimum_bandwidth_in_mbps LoadBalancerLoadBalancer#minimum_bandwidth_in_mbps}.</summary>
            [JsiiProperty(name: "minimumBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}")]
            public double MinimumBandwidthInMbps
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
