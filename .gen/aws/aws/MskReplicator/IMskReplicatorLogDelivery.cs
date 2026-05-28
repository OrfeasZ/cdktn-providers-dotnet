using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorLogDelivery), fullyQualifiedName: "aws.mskReplicator.MskReplicatorLogDelivery")]
    public interface IMskReplicatorLogDelivery
    {
        /// <summary>replicator_log_delivery block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#replicator_log_delivery MskReplicator#replicator_log_delivery}
        /// </remarks>
        [JsiiProperty(name: "replicatorLogDelivery", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDelivery\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery? ReplicatorLogDelivery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorLogDelivery), fullyQualifiedName: "aws.mskReplicator.MskReplicatorLogDelivery")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorLogDelivery
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>replicator_log_delivery block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/msk_replicator#replicator_log_delivery MskReplicator#replicator_log_delivery}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicatorLogDelivery", typeJson: "{\"fqn\":\"aws.mskReplicator.MskReplicatorLogDeliveryReplicatorLogDelivery\"}", isOptional: true)]
            public aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery? ReplicatorLogDelivery
            {
                get => GetInstanceProperty<aws.MskReplicator.IMskReplicatorLogDeliveryReplicatorLogDelivery?>();
            }
        }
    }
}
