using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationVideo")]
    public class BedrockdataautomationProjectStandardOutputConfigurationVideo : aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideo
    {
        private object? _extraction;

        /// <summary>extraction block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#extraction BedrockdataautomationProject#extraction}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideoExtraction" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extraction", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationVideoExtraction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Extraction
        {
            get => _extraction;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideoExtraction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideoExtraction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _extraction = value;
            }
        }

        private object? _generativeField;

        /// <summary>generative_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#generative_field BedrockdataautomationProject#generative_field}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideoGenerativeField" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "generativeField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationVideoGenerativeField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GenerativeField
        {
            get => _generativeField;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideoGenerativeField[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideoGenerativeField).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _generativeField = value;
            }
        }
    }
}
