using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentExtraction")]
    public class BedrockdataautomationProjectStandardOutputConfigurationDocumentExtraction : aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentExtraction
    {
        private object? _boundingBox;

        /// <summary>bounding_box block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#bounding_box BedrockdataautomationProject#bounding_box}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionBoundingBox" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boundingBox", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionBoundingBox\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? BoundingBox
        {
            get => _boundingBox;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionBoundingBox[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionBoundingBox).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _boundingBox = value;
            }
        }

        private object? _granularity;

        /// <summary>granularity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#granularity BedrockdataautomationProject#granularity}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionGranularity" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "granularity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionGranularity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Granularity
        {
            get => _granularity;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionGranularity[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentExtractionGranularity).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _granularity = value;
            }
        }
    }
}
