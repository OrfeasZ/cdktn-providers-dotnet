using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorKafkaClusterClientAuthentication), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthentication")]
    public interface IMskReplicatorKafkaClusterClientAuthentication
    {
        /// <summary>mtls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#mtls MskReplicator#mtls}
        /// </remarks>
        [JsiiProperty(name: "mtls", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls? Mtls
        {
            get
            {
                return null;
            }
        }

        /// <summary>sasl_scram block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#sasl_scram MskReplicator#sasl_scram}
        /// </remarks>
        [JsiiProperty(name: "saslScram", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScram\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram? SaslScram
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorKafkaClusterClientAuthentication), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>mtls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#mtls MskReplicator#mtls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mtls", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtls\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls? Mtls
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls?>();
            }

            /// <summary>sasl_scram block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#sasl_scram MskReplicator#sasl_scram}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "saslScram", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScram\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram? SaslScram
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram?>();
            }
        }
    }
}
