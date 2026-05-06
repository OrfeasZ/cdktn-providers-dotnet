using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalyzerTest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestDestinationEndpoint")]
    public class VnMonitoringPathAnalyzerTestDestinationEndpoint : oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestDestinationEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#type VnMonitoringPathAnalyzerTest#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#address VnMonitoringPathAnalyzerTest#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#instance_id VnMonitoringPathAnalyzerTest#instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#listener_id VnMonitoringPathAnalyzerTest#listener_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "listenerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ListenerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#load_balancer_id VnMonitoringPathAnalyzerTest#load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#network_load_balancer_id VnMonitoringPathAnalyzerTest#network_load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkLoadBalancerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#subnet_id VnMonitoringPathAnalyzerTest#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#vlan_id VnMonitoringPathAnalyzerTest#vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#vnic_id VnMonitoringPathAnalyzerTest#vnic_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vnicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VnicId
        {
            get;
            set;
        }
    }
}
