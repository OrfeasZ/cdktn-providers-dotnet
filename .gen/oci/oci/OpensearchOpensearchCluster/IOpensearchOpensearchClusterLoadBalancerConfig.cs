using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiInterface(nativeType: typeof(IOpensearchOpensearchClusterLoadBalancerConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterLoadBalancerConfig")]
    public interface IOpensearchOpensearchClusterLoadBalancerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/opensearch_opensearch_cluster#load_balancer_service_type OpensearchOpensearchCluster#load_balancer_service_type}.</summary>
        [JsiiProperty(name: "loadBalancerServiceType", typeJson: "{\"primitive\":\"string\"}")]
        string LoadBalancerServiceType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/opensearch_opensearch_cluster#load_balancer_max_bandwidth_in_mbps OpensearchOpensearchCluster#load_balancer_max_bandwidth_in_mbps}.</summary>
        [JsiiProperty(name: "loadBalancerMaxBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LoadBalancerMaxBandwidthInMbps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/opensearch_opensearch_cluster#load_balancer_min_bandwidth_in_mbps OpensearchOpensearchCluster#load_balancer_min_bandwidth_in_mbps}.</summary>
        [JsiiProperty(name: "loadBalancerMinBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LoadBalancerMinBandwidthInMbps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchOpensearchClusterLoadBalancerConfig), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterLoadBalancerConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterLoadBalancerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/opensearch_opensearch_cluster#load_balancer_service_type OpensearchOpensearchCluster#load_balancer_service_type}.</summary>
            [JsiiProperty(name: "loadBalancerServiceType", typeJson: "{\"primitive\":\"string\"}")]
            public string LoadBalancerServiceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/opensearch_opensearch_cluster#load_balancer_max_bandwidth_in_mbps OpensearchOpensearchCluster#load_balancer_max_bandwidth_in_mbps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerMaxBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LoadBalancerMaxBandwidthInMbps
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/opensearch_opensearch_cluster#load_balancer_min_bandwidth_in_mbps OpensearchOpensearchCluster#load_balancer_min_bandwidth_in_mbps}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerMinBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LoadBalancerMinBandwidthInMbps
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
