using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectOverrideConfigurationAudioLanguageConfiguration")]
    public class BedrockdataautomationProjectOverrideConfigurationAudioLanguageConfiguration : aws.BedrockdataautomationProject.IBedrockdataautomationProjectOverrideConfigurationAudioLanguageConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#generative_output_language BedrockdataautomationProject#generative_output_language}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "generativeOutputLanguage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GenerativeOutputLanguage
        {
            get;
            set;
        }

        private object? _identifyMultipleLanguages;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#identify_multiple_languages BedrockdataautomationProject#identify_multiple_languages}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "identifyMultipleLanguages", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IdentifyMultipleLanguages
        {
            get => _identifyMultipleLanguages;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _identifyMultipleLanguages = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#input_languages BedrockdataautomationProject#input_languages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputLanguages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? InputLanguages
        {
            get;
            set;
        }
    }
}
