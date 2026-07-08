using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreCodeInterpreter
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreCodeInterpreterCertificateLocation), fullyQualifiedName: "aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocation")]
    public interface IBedrockagentcoreCodeInterpreterCertificateLocation
    {
        /// <summary>secrets_manager block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/bedrockagentcore_code_interpreter#secrets_manager BedrockagentcoreCodeInterpreter#secrets_manager}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "secretsManager", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocationSecretsManager\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecretsManager
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreCodeInterpreterCertificateLocation), fullyQualifiedName: "aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocation")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>secrets_manager block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.54.0/docs/resources/bedrockagentcore_code_interpreter#secrets_manager BedrockagentcoreCodeInterpreter#secrets_manager}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretsManager", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocationSecretsManager\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SecretsManager
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
