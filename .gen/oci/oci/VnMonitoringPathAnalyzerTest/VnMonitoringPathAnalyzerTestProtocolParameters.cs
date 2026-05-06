using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalyzerTest
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.vnMonitoringPathAnalyzerTest.VnMonitoringPathAnalyzerTestProtocolParameters")]
    public class VnMonitoringPathAnalyzerTestProtocolParameters : oci.VnMonitoringPathAnalyzerTest.IVnMonitoringPathAnalyzerTestProtocolParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#type VnMonitoringPathAnalyzerTest#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#destination_port VnMonitoringPathAnalyzerTest#destination_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DestinationPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#icmp_code VnMonitoringPathAnalyzerTest#icmp_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "icmpCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IcmpCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#icmp_type VnMonitoringPathAnalyzerTest#icmp_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "icmpType", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IcmpType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analyzer_test#source_port VnMonitoringPathAnalyzerTest#source_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourcePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SourcePort
        {
            get;
            set;
        }
    }
}
