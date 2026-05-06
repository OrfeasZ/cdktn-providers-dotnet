using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaClusterSuperusersManagement
{
    [JsiiByValue(fqn: "oci.managedKafkaKafkaClusterSuperusersManagement.ManagedKafkaKafkaClusterSuperusersManagementTimeouts")]
    public class ManagedKafkaKafkaClusterSuperusersManagementTimeouts : oci.ManagedKafkaKafkaClusterSuperusersManagement.IManagedKafkaKafkaClusterSuperusersManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_superusers_management#create ManagedKafkaKafkaClusterSuperusersManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_superusers_management#delete ManagedKafkaKafkaClusterSuperusersManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_superusers_management#update ManagedKafkaKafkaClusterSuperusersManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
