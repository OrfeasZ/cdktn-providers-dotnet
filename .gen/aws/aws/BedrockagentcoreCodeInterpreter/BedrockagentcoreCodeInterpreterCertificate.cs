using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreCodeInterpreter
{
    [JsiiByValue(fqn: "aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificate")]
    public class BedrockagentcoreCodeInterpreterCertificate : aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificate
    {
        private object? _location;

        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/bedrockagentcore_code_interpreter#location BedrockagentcoreCodeInterpreter#location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterCertificateLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Location
        {
            get => _location;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterCertificateLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _location = value;
            }
        }
    }
}
