using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiInterface(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration")]
    public interface IBedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#pii_entity_types BedrockdataautomationProject#pii_entity_types}.</summary>
        [JsiiProperty(name: "piiEntityTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PiiEntityTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#redaction_mask_mode BedrockdataautomationProject#redaction_mask_mode}.</summary>
        [JsiiProperty(name: "redactionMaskMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedactionMaskMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration), fullyQualifiedName: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#pii_entity_types BedrockdataautomationProject#pii_entity_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "piiEntityTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PiiEntityTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#redaction_mask_mode BedrockdataautomationProject#redaction_mask_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redactionMaskMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedactionMaskMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
