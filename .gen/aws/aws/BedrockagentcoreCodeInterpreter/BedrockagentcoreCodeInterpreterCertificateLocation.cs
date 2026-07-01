using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreCodeInterpreter
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocation")]
    public class BedrockagentcoreCodeInterpreterCertificateLocation : aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocation
    {
        private object? _secretsManager;

        /// <summary>secrets_manager block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.53.0/docs/resources/bedrockagentcore_code_interpreter#secrets_manager BedrockagentcoreCodeInterpreter#secrets_manager}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManager", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocationSecretsManager\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SecretsManager
        {
            get => _secretsManager;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocationSecretsManager).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secretsManager = value;
            }
        }
    }
}
