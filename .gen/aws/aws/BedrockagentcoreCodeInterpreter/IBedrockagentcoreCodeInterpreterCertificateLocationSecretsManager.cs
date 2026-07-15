using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreCodeInterpreter
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager), fullyQualifiedName: "aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocationSecretsManager")]
    public interface IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/bedrockagentcore_code_interpreter#secret_arn BedrockagentcoreCodeInterpreter#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        string SecretArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager), fullyQualifiedName: "aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocationSecretsManager")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.55.0/docs/resources/bedrockagentcore_code_interpreter#secret_arn BedrockagentcoreCodeInterpreter#secret_arn}.</summary>
            [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
