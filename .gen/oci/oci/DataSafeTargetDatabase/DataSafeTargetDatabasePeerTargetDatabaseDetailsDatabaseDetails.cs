using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeTargetDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeTargetDatabase.DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails")]
    public class DataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails : oci.DataSafeTargetDatabase.IDataSafeTargetDatabasePeerTargetDatabaseDetailsDatabaseDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#database_type DataSafeTargetDatabase#database_type}.</summary>
        [JsiiProperty(name: "databaseType", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#infrastructure_type DataSafeTargetDatabase#infrastructure_type}.</summary>
        [JsiiProperty(name: "infrastructureType", typeJson: "{\"primitive\":\"string\"}")]
        public string InfrastructureType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#autonomous_database_id DataSafeTargetDatabase#autonomous_database_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autonomousDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AutonomousDatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#db_system_id DataSafeTargetDatabase#db_system_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DbSystemId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#instance_id DataSafeTargetDatabase#instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#ip_addresses DataSafeTargetDatabase#ip_addresses}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IpAddresses
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#listener_port DataSafeTargetDatabase#listener_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ListenerPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#pluggable_database_id DataSafeTargetDatabase#pluggable_database_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pluggableDatabaseId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PluggableDatabaseId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#service_name DataSafeTargetDatabase#service_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_target_database#vm_cluster_id DataSafeTargetDatabase#vm_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vmClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VmClusterId
        {
            get;
            set;
        }
    }
}
