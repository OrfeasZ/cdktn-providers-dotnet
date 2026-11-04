using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectStandardOutputConfigurationAudioExtraction), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtraction")]
    public interface IBedrockdataautomationProjectStandardOutputConfigurationAudioExtraction
    {
        /// <summary>category block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#category BedrockdataautomationProject#category}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategory" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "category", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Category
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectStandardOutputConfigurationAudioExtraction), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtraction")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtraction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>category block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#category BedrockdataautomationProject#category}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategory" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "category", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudioExtractionCategory\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Category
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
