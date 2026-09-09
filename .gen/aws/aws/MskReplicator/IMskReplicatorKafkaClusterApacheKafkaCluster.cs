using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorKafkaClusterApacheKafkaCluster), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterApacheKafkaCluster")]
    public interface IMskReplicatorKafkaClusterApacheKafkaCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#apache_kafka_cluster_id MskReplicator#apache_kafka_cluster_id}.</summary>
        [JsiiProperty(name: "apacheKafkaClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string ApacheKafkaClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#bootstrap_broker_string MskReplicator#bootstrap_broker_string}.</summary>
        [JsiiProperty(name: "bootstrapBrokerString", typeJson: "{\"primitive\":\"string\"}")]
        string BootstrapBrokerString
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorKafkaClusterApacheKafkaCluster), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterApacheKafkaCluster")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorKafkaClusterApacheKafkaCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#apache_kafka_cluster_id MskReplicator#apache_kafka_cluster_id}.</summary>
            [JsiiProperty(name: "apacheKafkaClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApacheKafkaClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#bootstrap_broker_string MskReplicator#bootstrap_broker_string}.</summary>
            [JsiiProperty(name: "bootstrapBrokerString", typeJson: "{\"primitive\":\"string\"}")]
            public string BootstrapBrokerString
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
