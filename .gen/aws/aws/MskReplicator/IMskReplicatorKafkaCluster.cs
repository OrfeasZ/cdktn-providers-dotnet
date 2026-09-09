using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorKafkaCluster), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaCluster")]
    public interface IMskReplicatorKafkaCluster
    {
        /// <summary>amazon_msk_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#amazon_msk_cluster MskReplicator#amazon_msk_cluster}
        /// </remarks>
        [JsiiProperty(name: "amazonMskCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster? AmazonMskCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>apache_kafka_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#apache_kafka_cluster MskReplicator#apache_kafka_cluster}
        /// </remarks>
        [JsiiProperty(name: "apacheKafkaCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterApacheKafkaCluster\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorKafkaClusterApacheKafkaCluster? ApacheKafkaCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>client_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#client_authentication MskReplicator#client_authentication}
        /// </remarks>
        [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthentication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthentication? ClientAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_in_transit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#encryption_in_transit MskReplicator#encryption_in_transit}
        /// </remarks>
        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterEncryptionInTransit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorKafkaClusterEncryptionInTransit? EncryptionInTransit
        {
            get
            {
                return null;
            }
        }

        /// <summary>vpc_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#vpc_config MskReplicator#vpc_config}
        /// </remarks>
        [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig? VpcConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorKafkaCluster), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaCluster")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorKafkaCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amazon_msk_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#amazon_msk_cluster MskReplicator#amazon_msk_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amazonMskCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterAmazonMskCluster\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster? AmazonMskCluster
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterAmazonMskCluster?>();
            }

            /// <summary>apache_kafka_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#apache_kafka_cluster MskReplicator#apache_kafka_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apacheKafkaCluster", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterApacheKafkaCluster\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorKafkaClusterApacheKafkaCluster? ApacheKafkaCluster
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterApacheKafkaCluster?>();
            }

            /// <summary>client_authentication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#client_authentication MskReplicator#client_authentication}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientAuthentication", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthentication\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthentication? ClientAuthentication
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthentication?>();
            }

            /// <summary>encryption_in_transit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#encryption_in_transit MskReplicator#encryption_in_transit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterEncryptionInTransit\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorKafkaClusterEncryptionInTransit? EncryptionInTransit
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterEncryptionInTransit?>();
            }

            /// <summary>vpc_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#vpc_config MskReplicator#vpc_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vpcConfig", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterVpcConfig\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig? VpcConfig
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterVpcConfig?>();
            }
        }
    }
}
