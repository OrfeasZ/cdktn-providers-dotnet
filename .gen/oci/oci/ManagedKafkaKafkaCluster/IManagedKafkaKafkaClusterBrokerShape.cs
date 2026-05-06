using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IManagedKafkaKafkaClusterBrokerShape), fullyQualifiedName: "oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterBrokerShape")]
    public interface IManagedKafkaKafkaClusterBrokerShape
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#node_count ManagedKafkaKafkaCluster#node_count}.</summary>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double NodeCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#ocpu_count ManagedKafkaKafkaCluster#ocpu_count}.</summary>
        [JsiiProperty(name: "ocpuCount", typeJson: "{\"primitive\":\"number\"}")]
        double OcpuCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#storage_size_in_gbs ManagedKafkaKafkaCluster#storage_size_in_gbs}.</summary>
        [JsiiProperty(name: "storageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StorageSizeInGbs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedKafkaKafkaClusterBrokerShape), fullyQualifiedName: "oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterBrokerShape")]
        internal sealed class _Proxy : DeputyBase, oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterBrokerShape
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#node_count ManagedKafkaKafkaCluster#node_count}.</summary>
            [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double NodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#ocpu_count ManagedKafkaKafkaCluster#ocpu_count}.</summary>
            [JsiiProperty(name: "ocpuCount", typeJson: "{\"primitive\":\"number\"}")]
            public double OcpuCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#storage_size_in_gbs ManagedKafkaKafkaCluster#storage_size_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageSizeInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StorageSizeInGbs
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
