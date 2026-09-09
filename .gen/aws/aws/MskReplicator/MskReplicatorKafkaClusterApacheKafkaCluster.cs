using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorKafkaClusterApacheKafkaCluster")]
    public class MskReplicatorKafkaClusterApacheKafkaCluster : aws.MskReplicator.IMskReplicatorKafkaClusterApacheKafkaCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#apache_kafka_cluster_id MskReplicator#apache_kafka_cluster_id}.</summary>
        [JsiiProperty(name: "apacheKafkaClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string ApacheKafkaClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#bootstrap_broker_string MskReplicator#bootstrap_broker_string}.</summary>
        [JsiiProperty(name: "bootstrapBrokerString", typeJson: "{\"primitive\":\"string\"}")]
        public string BootstrapBrokerString
        {
            get;
            set;
        }
    }
}
