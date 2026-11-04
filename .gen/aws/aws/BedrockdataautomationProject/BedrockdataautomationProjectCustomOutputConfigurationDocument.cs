using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocument")]
    public class BedrockdataautomationProjectCustomOutputConfigurationDocument : aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocument
    {
        private object? _fallbackBlueprint;

        /// <summary>fallback_blueprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#fallback_blueprint BedrockdataautomationProject#fallback_blueprint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fallbackBlueprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FallbackBlueprint
        {
            get => _fallbackBlueprint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fallbackBlueprint = value;
            }
        }
    }
}
