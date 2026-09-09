using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorKafkaClusterEncryptionInTransit), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterEncryptionInTransit")]
    public interface IMskReplicatorKafkaClusterEncryptionInTransit
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#root_ca_certificate MskReplicator#root_ca_certificate}.</summary>
        [JsiiProperty(name: "rootCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
        string RootCaCertificate
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorKafkaClusterEncryptionInTransit), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterEncryptionInTransit")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorKafkaClusterEncryptionInTransit
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#root_ca_certificate MskReplicator#root_ca_certificate}.</summary>
            [JsiiProperty(name: "rootCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
            public string RootCaCertificate
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
