using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocument")]
    public class BedrockdataautomationProjectOverrideConfigurationDocument : aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocument
    {
        private object? _modalityProcessing;

        /// <summary>modality_processing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#modality_processing BedrockdataautomationProject#modality_processing}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "modalityProcessing", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ModalityProcessing
        {
            get => _modalityProcessing;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _modalityProcessing = value;
            }
        }

        private object? _sensitiveDataConfiguration;

        /// <summary>sensitive_data_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#sensitive_data_configuration BedrockdataautomationProject#sensitive_data_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sensitiveDataConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SensitiveDataConfiguration
        {
            get => _sensitiveDataConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sensitiveDataConfiguration = value;
            }
        }

        private object? _splitter;

        /// <summary>splitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#splitter BedrockdataautomationProject#splitter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSplitter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "splitter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentSplitter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Splitter
        {
            get => _splitter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSplitter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSplitter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _splitter = value;
            }
        }
    }
}
