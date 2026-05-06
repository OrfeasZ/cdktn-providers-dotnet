using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IManagedKafkaKafkaClusterAccessSubnets), fullyQualifiedName: "oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterAccessSubnets")]
    public interface IManagedKafkaKafkaClusterAccessSubnets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#subnets ManagedKafkaKafkaCluster#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Subnets
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedKafkaKafkaClusterAccessSubnets), fullyQualifiedName: "oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterAccessSubnets")]
        internal sealed class _Proxy : DeputyBase, oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterAccessSubnets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#subnets ManagedKafkaKafkaCluster#subnets}.</summary>
            [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Subnets
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
