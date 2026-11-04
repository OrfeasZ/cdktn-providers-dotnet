using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfiguration")]
    public class BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfiguration : aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfiguration
    {
        private object? _transcript;

        /// <summary>transcript block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#transcript BedrockdataautomationProject#transcript}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transcript", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Transcript
        {
            get => _transcript;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _transcript = value;
            }
        }
    }
}
