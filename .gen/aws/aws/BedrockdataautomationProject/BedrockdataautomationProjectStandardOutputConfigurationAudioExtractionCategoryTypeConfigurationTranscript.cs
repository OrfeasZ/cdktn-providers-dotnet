using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript")]
    public class BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript : aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript
    {
        private object? _channelLabeling;

        /// <summary>channel_labeling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#channel_labeling BedrockdataautomationProject#channel_labeling}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptChannelLabeling" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "channelLabeling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptChannelLabeling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ChannelLabeling
        {
            get => _channelLabeling;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptChannelLabeling[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptChannelLabeling).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _channelLabeling = value;
            }
        }

        private object? _speakerLabeling;

        /// <summary>speaker_labeling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#speaker_labeling BedrockdataautomationProject#speaker_labeling}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptSpeakerLabeling" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "speakerLabeling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptSpeakerLabeling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SpeakerLabeling
        {
            get => _speakerLabeling;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptSpeakerLabeling[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptSpeakerLabeling).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _speakerLabeling = value;
            }
        }
    }
}
