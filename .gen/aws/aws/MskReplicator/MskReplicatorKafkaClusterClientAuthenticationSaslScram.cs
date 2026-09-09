using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScram")]
    public class MskReplicatorKafkaClusterClientAuthenticationSaslScram : aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#mechanism MskReplicator#mechanism}.</summary>
        [JsiiProperty(name: "mechanism", typeJson: "{\"primitive\":\"string\"}")]
        public string Mechanism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#secret_arn MskReplicator#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretArn
        {
            get;
            set;
        }
    }
}
