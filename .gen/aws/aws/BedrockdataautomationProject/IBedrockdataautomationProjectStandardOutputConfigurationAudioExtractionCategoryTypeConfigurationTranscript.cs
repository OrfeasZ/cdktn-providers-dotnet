using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript")]
    public interface IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript
    {
        /// <summary>channel_labeling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#channel_labeling BedrockdataautomationProject#channel_labeling}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptChannelLabeling" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "channelLabeling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptChannelLabeling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ChannelLabeling
        {
            get
            {
                return null;
            }
        }

        /// <summary>speaker_labeling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#speaker_labeling BedrockdataautomationProject#speaker_labeling}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptSpeakerLabeling" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "speakerLabeling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptSpeakerLabeling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SpeakerLabeling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscript
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>channel_labeling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#channel_labeling BedrockdataautomationProject#channel_labeling}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptChannelLabeling" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "channelLabeling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptChannelLabeling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ChannelLabeling
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>speaker_labeling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#speaker_labeling BedrockdataautomationProject#speaker_labeling}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptSpeakerLabeling" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "speakerLabeling", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategoryTypeConfigurationTranscriptSpeakerLabeling\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SpeakerLabeling
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
