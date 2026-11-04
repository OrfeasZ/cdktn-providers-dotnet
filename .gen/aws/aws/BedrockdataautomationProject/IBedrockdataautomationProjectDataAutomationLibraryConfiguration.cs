using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectDataAutomationLibraryConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectDataAutomationLibraryConfiguration")]
    public interface IBedrockdataautomationProjectDataAutomationLibraryConfiguration
    {
        /// <summary>library block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#library BedrockdataautomationProject#library}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "library", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Library
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectDataAutomationLibraryConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectDataAutomationLibraryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectDataAutomationLibraryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>library block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#library BedrockdataautomationProject#library}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "library", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Library
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
