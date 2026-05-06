using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalysi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiSourceEndpoint")]
    public class VnMonitoringPathAnalysiSourceEndpoint : oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiSourceEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#type VnMonitoringPathAnalysi#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#address VnMonitoringPathAnalysi#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#instance_id VnMonitoringPathAnalysi#instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#listener_id VnMonitoringPathAnalysi#listener_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "listenerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ListenerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#load_balancer_id VnMonitoringPathAnalysi#load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LoadBalancerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#network_load_balancer_id VnMonitoringPathAnalysi#network_load_balancer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkLoadBalancerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#subnet_id VnMonitoringPathAnalysi#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#vlan_id VnMonitoringPathAnalysi#vlan_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VlanId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#vnic_id VnMonitoringPathAnalysi#vnic_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vnicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VnicId
        {
            get;
            set;
        }
    }
}
