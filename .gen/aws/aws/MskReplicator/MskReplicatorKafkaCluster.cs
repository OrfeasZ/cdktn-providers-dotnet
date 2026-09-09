using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorKafkaCluster")]
    public class MskReplicatorKafkaCluster : aws.MskReplicator.IMskReplicatorKafkaCluster
    {
        /// <summary>amazon_msk_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#amazon_msk_cluster MskReplicator#amazon_msk_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amazonMskCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster? AmazonMskCluster
        {
            get;
            set;
        }

        /// <summary>apache_kafka_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#apache_kafka_cluster MskReplicator#apache_kafka_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apacheKafkaCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterApacheKafkaCluster\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorKafkaClusterApacheKafkaCluster? ApacheKafkaCluster
        {
            get;
            set;
        }

        /// <summary>client_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#client_authentication MskReplicator#client_authentication}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthentication\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthentication? ClientAuthentication
        {
            get;
            set;
        }

        /// <summary>encryption_in_transit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#encryption_in_transit MskReplicator#encryption_in_transit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterEncryptionInTransit\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorKafkaClusterEncryptionInTransit? EncryptionInTransit
        {
            get;
            set;
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#vpc_config MskReplicator#vpc_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfig\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig? VpcConfig
        {
            get;
            set;
        }
    }
}
