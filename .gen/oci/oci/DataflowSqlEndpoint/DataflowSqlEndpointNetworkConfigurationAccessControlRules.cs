using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowSqlEndpoint
{
    [JsiiByValue(fqn: "oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationAccessControlRules")]
    public class DataflowSqlEndpointNetworkConfigurationAccessControlRules : oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfigurationAccessControlRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#ip_notation DataflowSqlEndpoint#ip_notation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipNotation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpNotation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#value DataflowSqlEndpoint#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#vcn_ips DataflowSqlEndpoint#vcn_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vcnIps", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VcnIps
        {
            get;
            set;
        }
    }
}
