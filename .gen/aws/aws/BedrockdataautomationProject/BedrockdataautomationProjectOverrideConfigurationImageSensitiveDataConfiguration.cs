using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfiguration")]
    public class BedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfiguration : aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#detection_mode BedrockdataautomationProject#detection_mode}.</summary>
        [JsiiProperty(name: "detectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public string DetectionMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#detection_scope BedrockdataautomationProject#detection_scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "detectionScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DetectionScope
        {
            get;
            set;
        }

        private object? _piiEntitiesConfiguration;

        /// <summary>pii_entities_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.73.0/docs/resources/bedrockdataautomation_project#pii_entities_configuration BedrockdataautomationProject#pii_entities_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "piiEntitiesConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? PiiEntitiesConfiguration
        {
            get => _piiEntitiesConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationImageSensitiveDataConfigurationPiiEntitiesConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _piiEntitiesConfiguration = value;
            }
        }
    }
}
