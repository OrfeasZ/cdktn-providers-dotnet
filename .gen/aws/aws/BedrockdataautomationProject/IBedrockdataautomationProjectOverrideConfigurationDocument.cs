using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationDocument), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocument")]
    public interface IBedrockdataautomationProjectOverrideConfigurationDocument
    {
        /// <summary>modality_processing block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#modality_processing BedrockdataautomationProject#modality_processing}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "modalityProcessing", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "sensitiveDataConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SensitiveDataConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>splitter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#splitter BedrockdataautomationProject#splitter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSplitter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "splitter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentSplitter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Splitter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationDocument), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocument")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>modality_processing block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#modality_processing BedrockdataautomationProject#modality_processing}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "modalityProcessing", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentModalityProcessing\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ModalityProcessing
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sensitive_data_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#sensitive_data_configuration BedrockdataautomationProject#sensitive_data_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sensitiveDataConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentSensitiveDataConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SensitiveDataConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>splitter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#splitter BedrockdataautomationProject#splitter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationDocumentSplitter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "splitter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationDocumentSplitter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Splitter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
