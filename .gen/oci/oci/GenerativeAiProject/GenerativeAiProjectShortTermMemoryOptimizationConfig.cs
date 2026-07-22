using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiProject
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfig")]
    public class GenerativeAiProjectShortTermMemoryOptimizationConfig : oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfig
    {
        private object _isEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_project#is_enabled GenerativeAiProject#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsEnabled
        {
            get => _isEnabled;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEnabled = value;
            }
        }

        /// <summary>condenser_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/generative_ai_project#condenser_config GenerativeAiProject#condenser_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condenserConfig", typeJson: "{\"fqn\":\"oci.generativeAiProject.GenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig\"}", isOptional: true)]
        public oci.GenerativeAiProject.IGenerativeAiProjectShortTermMemoryOptimizationConfigCondenserConfig? CondenserConfig
        {
            get;
            set;
        }
    }
}
