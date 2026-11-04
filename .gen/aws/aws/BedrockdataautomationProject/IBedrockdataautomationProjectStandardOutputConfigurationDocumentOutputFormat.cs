using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat")]
    public interface IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat
    {
        /// <summary>additional_file_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#additional_file_format BedrockdataautomationProject#additional_file_format}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatAdditionalFileFormat" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "additionalFileFormat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatAdditionalFileFormat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AdditionalFileFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>text_format block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#text_format BedrockdataautomationProject#text_format}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatTextFormat" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "textFormat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatTextFormat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TextFormat
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormat
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>additional_file_format block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#additional_file_format BedrockdataautomationProject#additional_file_format}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatAdditionalFileFormat" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalFileFormat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatAdditionalFileFormat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AdditionalFileFormat
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>text_format block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#text_format BedrockdataautomationProject#text_format}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatTextFormat" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "textFormat", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocumentOutputFormatTextFormat\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TextFormat
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
