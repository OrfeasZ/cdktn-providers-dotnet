using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.KafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.kafkaCluster.KafkaClusterPrivateNetwork")]
    public class KafkaClusterPrivateNetwork : scaleway.KafkaCluster.IKafkaClusterPrivateNetwork
    {
        /// <summary>The private network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/kafka_cluster#pn_id KafkaCluster#pn_id}
        /// </remarks>
        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        public string PnId
        {
            get;
            set;
        }
    }
}
