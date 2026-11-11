using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat")]
    public class BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat : aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat
    {
        private object? _additionalFileFormat;

        /// <summary>additional_file_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#additional_file_format BedrockdataautomationProject#additional_file_format}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatAdditionalFileFormat" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalFileFormat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatAdditionalFileFormat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AdditionalFileFormat
        {
            get => _additionalFileFormat;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatAdditionalFileFormat[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatAdditionalFileFormat).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _additionalFileFormat = value;
            }
        }

        private object? _textFormat;

        /// <summary>text_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#text_format BedrockdataautomationProject#text_format}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatTextFormat" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "textFormat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatTextFormat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TextFormat
        {
            get => _textFormat;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatTextFormat[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatTextFormat).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _textFormat = value;
            }
        }
    }
}
