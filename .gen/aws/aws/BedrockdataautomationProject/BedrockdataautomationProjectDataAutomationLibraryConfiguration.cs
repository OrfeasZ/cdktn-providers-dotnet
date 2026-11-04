using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockdataautomationProject
{
    [JsiiByValue(fqn: "aws.bedrockdataautomationProject.BedrockdataautomationProjectDataAutomationLibraryConfiguration")]
    public class BedrockdataautomationProjectDataAutomationLibraryConfiguration : aws.BedrockdataautomationProject.IBedrockdataautomationProjectDataAutomationLibraryConfiguration
    {
        private object? _library;

        /// <summary>library block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/bedrockdataautomation_project#library BedrockdataautomationProject#library}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockdataautomationProject.IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "library", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockdataautomationProject.BedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Library
        {
            get => _library;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockdataautomationProject.IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.BedrockdataautomationProject.IBedrockdataautomationProjectDataAutomationLibraryConfigurationLibrary).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _library = value;
            }
        }
    }
}
