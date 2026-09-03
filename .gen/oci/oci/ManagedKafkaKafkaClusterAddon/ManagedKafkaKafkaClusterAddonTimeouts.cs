using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaClusterAddon
{
    [JsiiByValue(fqn: "oci.managedKafkaKafkaClusterAddon.ManagedKafkaKafkaClusterAddonTimeouts")]
    public class ManagedKafkaKafkaClusterAddonTimeouts : oci.ManagedKafkaKafkaClusterAddon.IManagedKafkaKafkaClusterAddonTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/managed_kafka_kafka_cluster_addon#create ManagedKafkaKafkaClusterAddon#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/managed_kafka_kafka_cluster_addon#delete ManagedKafkaKafkaClusterAddon#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/managed_kafka_kafka_cluster_addon#update ManagedKafkaKafkaClusterAddon#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
