using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaClusterConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.managedKafkaKafkaClusterConfig.ManagedKafkaKafkaClusterConfigLatestConfig")]
    public class ManagedKafkaKafkaClusterConfigLatestConfig : oci.ManagedKafkaKafkaClusterConfig.IManagedKafkaKafkaClusterConfigLatestConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#properties ManagedKafkaKafkaClusterConfigA#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Properties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#config_id ManagedKafkaKafkaClusterConfigA#config_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConfigId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#version_number ManagedKafkaKafkaClusterConfigA#version_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? VersionNumber
        {
            get;
            set;
        }
    }
}
