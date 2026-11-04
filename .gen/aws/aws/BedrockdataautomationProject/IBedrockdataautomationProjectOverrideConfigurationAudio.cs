using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationAudio), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudio")]
    public interface IBedrockdataautomationProjectOverrideConfigurationAudio
    {
        /// <summary>language_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#language_configuration BedrockdataautomationProject#language_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationAudioLanguageConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "languageConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudioLanguageConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LanguageConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>modality_processing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#modality_processing BedrockdataautomationProject#modality_processing}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationAudioModalityProcessing" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "modalityProcessing", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudioModalityProcessing\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ModalityProcessing
        {
            get
            {
                return null;
            }
        }

        /// <summary>sensitive_data_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#sensitive_data_configuration BedrockdataautomationProject#sensitive_data_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationAudioSensitiveDataConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sensitiveDataConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudioSensitiveDataConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SensitiveDataConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationAudio), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudio")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationAudio
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>language_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#language_configuration BedrockdataautomationProject#language_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationAudioLanguageConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "languageConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudioLanguageConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LanguageConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>modality_processing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#modality_processing BedrockdataautomationProject#modality_processing}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationAudioModalityProcessing" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modalityProcessing", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudioModalityProcessing\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModalityProcessing
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sensitive_data_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#sensitive_data_configuration BedrockdataautomationProject#sensitive_data_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationAudioSensitiveDataConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveDataConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudioSensitiveDataConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SensitiveDataConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
