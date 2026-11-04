using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectStandardOutputConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfiguration")]
    public interface IBedrockdataautomationProjectStandardOutputConfiguration
    {
        /// <summary>audio block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#audio BedrockdataautomationProject#audio}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudio" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "audio", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudio\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Audio
        {
            get
            {
                return null;
            }
        }

        /// <summary>document block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#document BedrockdataautomationProject#document}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocument" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "document", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Document
        {
            get
            {
                return null;
            }
        }

        /// <summary>image block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#image BedrockdataautomationProject#image}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationImage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "image", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Image
        {
            get
            {
                return null;
            }
        }

        /// <summary>video block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#video BedrockdataautomationProject#video}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideo" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "video", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationVideo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Video
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectStandardOutputConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audio block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#audio BedrockdataautomationProject#audio}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationAudio" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audio", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationAudio\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Audio
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>document block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#document BedrockdataautomationProject#document}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationDocument" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "document", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationDocument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Document
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>image block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#image BedrockdataautomationProject#image}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationImage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "image", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Image
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>video block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#video BedrockdataautomationProject#video}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectStandardOutputConfigurationVideo" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "video", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectStandardOutputConfigurationVideo\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Video
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
