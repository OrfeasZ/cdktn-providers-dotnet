using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalyzerTest
{
    [JsiiInterface(nativeType: typeof(IVnMonitoringPathAnalyzerTestSourceEndpoint), fullyQualifiedName: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpoint")]
    public interface IVnMonitoringPathAnalyzerTestSourceEndpoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#type VnMonitoringPathAnalyzerTest#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#address VnMonitoringPathAnalyzerTest#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#instance_id VnMonitoringPathAnalyzerTest#instance_id}.</summary>
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? InstanceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#listener_id VnMonitoringPathAnalyzerTest#listener_id}.</summary>
        [JsiiProperty(name: "listenerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ListenerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#load_balancer_id VnMonitoringPathAnalyzerTest#load_balancer_id}.</summary>
        [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#network_load_balancer_id VnMonitoringPathAnalyzerTest#network_load_balancer_id}.</summary>
        [JsiiProperty(name: "networkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkLoadBalancerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#subnet_id VnMonitoringPathAnalyzerTest#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#vlan_id VnMonitoringPathAnalyzerTest#vlan_id}.</summary>
        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VlanId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#vnic_id VnMonitoringPathAnalyzerTest#vnic_id}.</summary>
        [JsiiProperty(name: "vnicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VnicId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVnMonitoringPathAnalyzerTestSourceEndpoint), fullyQualifiedName: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestSourceEndpoint")]
        internal sealed class _Proxy : DeputyBase, oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestSourceEndpoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#type VnMonitoringPathAnalyzerTest#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#address VnMonitoringPathAnalyzerTest#address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#instance_id VnMonitoringPathAnalyzerTest#instance_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? InstanceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#listener_id VnMonitoringPathAnalyzerTest#listener_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "listenerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ListenerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#load_balancer_id VnMonitoringPathAnalyzerTest#load_balancer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#network_load_balancer_id VnMonitoringPathAnalyzerTest#network_load_balancer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkLoadBalancerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkLoadBalancerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#subnet_id VnMonitoringPathAnalyzerTest#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#vlan_id VnMonitoringPathAnalyzerTest#vlan_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VlanId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#vnic_id VnMonitoringPathAnalyzerTest#vnic_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vnicId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VnicId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
