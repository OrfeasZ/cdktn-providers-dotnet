using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfiguration")]
    public interface IBedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#detection_mode BedrockdataautomationProject#detection_mode}.</summary>
        [JsiiProperty(name: "detectionMode", typeJson: "{\"primitive\":\"string\"}")]
        string DetectionMode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#detection_scope BedrockdataautomationProject#detection_scope}.</summary>
        [JsiiProperty(name: "detectionScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DetectionScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>pii_entities_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#pii_entities_configuration BedrockdataautomationProject#pii_entities_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfigurationPiiEntitiesConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "piiEntitiesConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfigurationPiiEntitiesConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PiiEntitiesConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#detection_mode BedrockdataautomationProject#detection_mode}.</summary>
            [JsiiProperty(name: "detectionMode", typeJson: "{\"primitive\":\"string\"}")]
            public string DetectionMode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#detection_scope BedrockdataautomationProject#detection_scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "detectionScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DetectionScope
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>pii_entities_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#pii_entities_configuration BedrockdataautomationProject#pii_entities_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfigurationPiiEntitiesConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "piiEntitiesConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationVideoSensitiveDataConfigurationPiiEntitiesConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PiiEntitiesConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
