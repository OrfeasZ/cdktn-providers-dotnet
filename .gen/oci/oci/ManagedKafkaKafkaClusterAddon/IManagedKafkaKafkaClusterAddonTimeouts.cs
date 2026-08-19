using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaClusterAddon
{
    [JsiiInterface(nativeType: typeof(IManagedKafkaKafkaClusterAddonTimeouts), fullyQualifiedName: "oci.managedKafkaKafkaClusterAddon.ManagedKafkaKafkaClusterAddonTimeouts")]
    public interface IManagedKafkaKafkaClusterAddonTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/managed_kafka_kafka_cluster_addon#create ManagedKafkaKafkaClusterAddon#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/managed_kafka_kafka_cluster_addon#delete ManagedKafkaKafkaClusterAddon#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/managed_kafka_kafka_cluster_addon#update ManagedKafkaKafkaClusterAddon#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedKafkaKafkaClusterAddonTimeouts), fullyQualifiedName: "oci.managedKafkaKafkaClusterAddon.ManagedKafkaKafkaClusterAddonTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.ManagedKafkaKafkaClusterAddon.IManagedKafkaKafkaClusterAddonTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/managed_kafka_kafka_cluster_addon#create ManagedKafkaKafkaClusterAddon#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/managed_kafka_kafka_cluster_addon#delete ManagedKafkaKafkaClusterAddon#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/managed_kafka_kafka_cluster_addon#update ManagedKafkaKafkaClusterAddon#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
