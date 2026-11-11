using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectCustomOutputConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfiguration")]
    public interface IBedrockdataautomationProjectCustomOutputConfiguration
    {
        /// <summary>blueprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#blueprint BedrockdataautomationProject#blueprint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationBlueprint" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "blueprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationBlueprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Blueprint
        {
            get
            {
                return null;
            }
        }

        /// <summary>document block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#document BedrockdataautomationProject#document}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocument" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "document", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Document
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectCustomOutputConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>blueprint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#blueprint BedrockdataautomationProject#blueprint}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationBlueprint" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "blueprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationBlueprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Blueprint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>document block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#document BedrockdataautomationProject#document}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocument" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "document", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocument\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Document
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
