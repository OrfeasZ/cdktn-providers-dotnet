using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagedKafkaKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.managedKafkaKafkaCluster.ManagedKafkaKafkaClusterAccessSubnets")]
    public class ManagedKafkaKafkaClusterAccessSubnets : oci.ManagedKafkaKafkaCluster.IManagedKafkaKafkaClusterAccessSubnets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/managed_kafka_kafka_cluster#subnets ManagedKafkaKafkaCluster#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Subnets
        {
            get;
            set;
        }
    }
}
