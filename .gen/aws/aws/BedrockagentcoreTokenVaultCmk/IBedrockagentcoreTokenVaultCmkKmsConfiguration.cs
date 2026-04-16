using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreTokenVaultCmk
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreTokenVaultCmkKmsConfiguration), fullyQualifiedName: "aws.bedrockagentcoreTokenVaultCmk.BedrockagentcoreTokenVaultCmkKmsConfiguration")]
    public interface IBedrockagentcoreTokenVaultCmkKmsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_token_vault_cmk#key_type BedrockagentcoreTokenVaultCmk#key_type}.</summary>
        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        string KeyType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_token_vault_cmk#kms_key_arn BedrockagentcoreTokenVaultCmk#kms_key_arn}.</summary>
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreTokenVaultCmkKmsConfiguration), fullyQualifiedName: "aws.bedrockagentcoreTokenVaultCmk.BedrockagentcoreTokenVaultCmkKmsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreTokenVaultCmk.IBedrockagentcoreTokenVaultCmkKmsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_token_vault_cmk#key_type BedrockagentcoreTokenVaultCmk#key_type}.</summary>
            [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_token_vault_cmk#kms_key_arn BedrockagentcoreTokenVaultCmk#kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
