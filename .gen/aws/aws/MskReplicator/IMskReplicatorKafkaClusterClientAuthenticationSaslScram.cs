using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskReplicator
{
    [JsiiInterface(nativeType: typeof(IMskReplicatorKafkaClusterClientAuthenticationSaslScram), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScram")]
    public interface IMskReplicatorKafkaClusterClientAuthenticationSaslScram
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#mechanism MskReplicator#mechanism}.</summary>
        [JsiiProperty(name: "mechanism", typeJson: "{\"primitive\":\"string\"}")]
        string Mechanism
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#secret_arn MskReplicator#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        string SecretArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskReplicatorKafkaClusterClientAuthenticationSaslScram), fullyQualifiedName: "aws.mskReplicator.MskReplicatorKafkaClusterClientAuthenticationSaslScram")]
        internal sealed class _Proxy : DeputyBase, aws.MskReplicator.IMskReplicatorKafkaClusterClientAuthenticationSaslScram
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.64.0/docs/resources/msk_replicator#mechanism MskReplicator#mechanism}.</summary>
            [JsiiProperty(name: "mechanism", typeJson: "{\"primitive\":\"string\"}")]
            public string Mechanism
            {
                get => GetInstanceProperty<string>()!;
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
