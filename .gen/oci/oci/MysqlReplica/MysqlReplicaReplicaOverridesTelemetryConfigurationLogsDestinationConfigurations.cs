using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.MysqlReplica
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.mysqlReplica.MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations")]
    public class MysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations : oci.MysqlReplica.IMysqlReplicaReplicaOverridesTelemetryConfigurationLogsDestinationConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/mysql_replica#key MysqlReplica#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/mysql_replica#value MysqlReplica#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
