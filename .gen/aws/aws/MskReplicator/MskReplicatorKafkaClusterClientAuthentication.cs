using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthentication")]
    public class MskReplicatorKafkaClusterClientAuthentication : aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthentication
    {
        /// <summary>mtls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#mtls MskReplicator#mtls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mtls", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtls\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls? Mtls
        {
            get;
            set;
        }

        /// <summary>sasl_scram block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#sasl_scram MskReplicator#sasl_scram}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "saslScram", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScram\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram? SaslScram
        {
            get;
            set;
        }
    }
}
