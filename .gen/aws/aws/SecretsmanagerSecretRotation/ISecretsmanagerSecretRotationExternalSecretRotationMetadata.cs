using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecretsmanagerSecretRotation
{
    [JsiiInterface(nativeType: typeof(ISecretsmanagerSecretRotationExternalSecretRotationMetadata), fullyQualifiedName: "aws.secretsmanagerSecretRotation.SecretsmanagerSecretRotationExternalSecretRotationMetadata")]
    public interface ISecretsmanagerSecretRotationExternalSecretRotationMetadata
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/secretsmanager_secret_rotation#key SecretsmanagerSecretRotation#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/secretsmanager_secret_rotation#value SecretsmanagerSecretRotation#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecretsmanagerSecretRotationExternalSecretRotationMetadata), fullyQualifiedName: "aws.secretsmanagerSecretRotation.SecretsmanagerSecretRotationExternalSecretRotationMetadata")]
        internal sealed class _Proxy : DeputyBase, aws.SecretsmanagerSecretRotation.ISecretsmanagerSecretRotationExternalSecretRotationMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/secretsmanager_secret_rotation#key SecretsmanagerSecretRotation#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/secretsmanager_secret_rotation#value SecretsmanagerSecretRotation#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
