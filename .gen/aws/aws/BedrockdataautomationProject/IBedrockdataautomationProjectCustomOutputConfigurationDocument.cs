using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectCustomOutputConfigurationDocument), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocument")]
    public interface IBedrockdataautomationProjectCustomOutputConfigurationDocument
    {
        /// <summary>fallback_blueprint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#fallback_blueprint BedrockdataautomationProject#fallback_blueprint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "fallbackBlueprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FallbackBlueprint
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectCustomOutputConfigurationDocument), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocument")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocument
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fallback_blueprint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#fallback_blueprint BedrockdataautomationProject#fallback_blueprint}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fallbackBlueprint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectCustomOutputConfigurationDocumentFallbackBlueprint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FallbackBlueprint
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
