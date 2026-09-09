using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorKafkaClusterClientAuthenticationMtls), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtls")]
    public interface IMskReplicatorKafkaClusterClientAuthenticationMtls
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#secret_arn MskReplicator#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        string SecretArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorKafkaClusterClientAuthenticationMtls), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationMtls")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationMtls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#secret_arn MskReplicator#secret_arn}.</summary>
            [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
