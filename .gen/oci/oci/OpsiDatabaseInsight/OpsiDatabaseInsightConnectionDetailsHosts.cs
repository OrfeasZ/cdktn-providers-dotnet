using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpsiDatabaseInsight
{
    [JsiiByValue(fqn: "oci.opsiDatabaseInsight.OpsiDatabaseInsightConnectionDetailsHosts")]
    public class OpsiDatabaseInsightConnectionDetailsHosts : oci.OpsiDatabaseInsight.IOpsiDatabaseInsightConnectionDetailsHosts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#host_ip OpsiDatabaseInsight#host_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostIp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/opsi_database_insight#port OpsiDatabaseInsight#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
