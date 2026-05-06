using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterBrokerShape")]
    public class ManagedKafkaKafkaClusterBrokerShape : oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterBrokerShape
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#node_count ManagedKafkaKafkaCluster#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double NodeCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#ocpu_count ManagedKafkaKafkaCluster#ocpu_count}.</summary>
        [JsiiProperty(name: "ocpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public double OcpuCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#storage_size_in_gbs ManagedKafkaKafkaCluster#storage_size_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "storageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StorageSizeInGbs
        {
            get;
            set;
        }
    }
}
