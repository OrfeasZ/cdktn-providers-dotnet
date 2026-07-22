using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterLoadBalancerConfig")]
    public class OpensearchOpensearchClusterLoadBalancerConfig : oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterLoadBalancerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/opensearch_opensearch_cluster#load_balancer_service_type OpensearchOpensearchCluster#load_balancer_service_type}.</summary>
        [JsiiProperty(name: "loadBalancerServiceType", typeJson: "{\"primitive\":\"string\"}")]
        public string LoadBalancerServiceType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/opensearch_opensearch_cluster#load_balancer_max_bandwidth_in_mbps OpensearchOpensearchCluster#load_balancer_max_bandwidth_in_mbps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerMaxBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoadBalancerMaxBandwidthInMbps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/opensearch_opensearch_cluster#load_balancer_min_bandwidth_in_mbps OpensearchOpensearchCluster#load_balancer_min_bandwidth_in_mbps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerMinBandwidthInMbps", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LoadBalancerMinBandwidthInMbps
        {
            get;
            set;
        }
    }
}
