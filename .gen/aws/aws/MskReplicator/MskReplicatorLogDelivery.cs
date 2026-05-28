using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiByValue(fqn: "aws.mskReplicator.MskReplicatorLogDelivery")]
    public class MskReplicatorLogDelivery : aws.MskReplicator.IMskReplicatorLogDelivery
    {
        /// <summary>replicator_log_delivery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#replicator_log_delivery MskReplicator#replicator_log_delivery}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicatorLogDelivery", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDelivery\"}", isOptional: true)]
        public aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery? ReplicatorLogDelivery
        {
            get;
            set;
        }
    }
}
