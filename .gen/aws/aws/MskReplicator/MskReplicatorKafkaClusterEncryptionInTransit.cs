using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorKafkaClusterEncryptionInTransit")]
    public class MskReplicatorKafkaClusterEncryptionInTransit : aws.MskReplicator.IMskReplicatorKafkaClusterEncryptionInTransit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#root_ca_certificate MskReplicator#root_ca_certificate}.</summary>
        [JsiiProperty(name: "rootCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public string RootCaCertificate
        {
            get;
            set;
        }
    }
}
