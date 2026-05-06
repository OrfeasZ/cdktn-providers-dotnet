using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VnMonitoringPathAnalysi
{
    [JsiiByValue(fqn: "oci.vnMonitoringPathAnalysi.VnMonitoringPathAnalysiTimeouts")]
    public class VnMonitoringPathAnalysiTimeouts : oci.VnMonitoringPathAnalysi.IVnMonitoringPathAnalysiTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#create VnMonitoringPathAnalysi#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#delete VnMonitoringPathAnalysi#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/vn_monitoring_path_analysi#update VnMonitoringPathAnalysi#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
