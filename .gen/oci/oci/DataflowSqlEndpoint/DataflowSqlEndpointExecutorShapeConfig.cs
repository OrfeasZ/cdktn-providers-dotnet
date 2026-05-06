using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowSqlEndpoint
{
    [JsiiByValue(fqn: "oci.dataflowSqlEndpoint.DataflowSqlEndpointExecutorShapeConfig")]
    public class DataflowSqlEndpointExecutorShapeConfig : oci.DataflowSqlEndpoint.IDataflowSqlEndpointExecutorShapeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#memory_in_gbs DataflowSqlEndpoint#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataflow_sql_endpoint#ocpus DataflowSqlEndpoint#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }
    }
}
