using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaClusterConfig
{
    [JsiiInterface(nativeType: typeof(IManagedKafkaKafkaClusterConfigLatestConfig), fullyQualifiedName: "oci.managedKafkaKafkaClusterConfig.ManagedKafkaKafkaClusterConfigLatestConfig")]
    public interface IManagedKafkaKafkaClusterConfigLatestConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#properties ManagedKafkaKafkaClusterConfigA#properties}.</summary>
        [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Properties
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#config_id ManagedKafkaKafkaClusterConfigA#config_id}.</summary>
        [JsiiProperty(name: "configId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#version_number ManagedKafkaKafkaClusterConfigA#version_number}.</summary>
        [JsiiProperty(name: "versionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? VersionNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedKafkaKafkaClusterConfigLatestConfig), fullyQualifiedName: "oci.managedKafkaKafkaClusterConfig.ManagedKafkaKafkaClusterConfigLatestConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ManagedKafkaKafkaClusterConfig.IManagedKafkaKafkaClusterConfigLatestConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#properties ManagedKafkaKafkaClusterConfigA#properties}.</summary>
            [JsiiProperty(name: "properties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Properties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#config_id ManagedKafkaKafkaClusterConfigA#config_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster_config#version_number ManagedKafkaKafkaClusterConfigA#version_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionNumber", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? VersionNumber
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
