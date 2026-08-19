using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointHumanInputConfig")]
    public class GenerativeAiAgentAgentEndpointHumanInputConfig : oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointHumanInputConfig
    {
        private object _shouldEnableHumanInput;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/generative_ai_agent_agent_endpoint#should_enable_human_input GenerativeAiAgentAgentEndpoint#should_enable_human_input}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "shouldEnableHumanInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object ShouldEnableHumanInput
        {
            get => _shouldEnableHumanInput;
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
                _shouldEnableHumanInput = value;
            }
        }
    }
}
