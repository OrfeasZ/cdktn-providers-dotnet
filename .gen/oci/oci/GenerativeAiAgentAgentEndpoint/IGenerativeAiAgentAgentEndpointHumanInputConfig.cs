using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiAgentAgentEndpoint
{
    [JsiiInterface(nativeType: typeof(IGenerativeAiAgentAgentEndpointHumanInputConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointHumanInputConfig")]
    public interface IGenerativeAiAgentAgentEndpointHumanInputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#should_enable_human_input GenerativeAiAgentAgentEndpoint#should_enable_human_input}.</summary>
        [JsiiProperty(name: "shouldEnableHumanInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object ShouldEnableHumanInput
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGenerativeAiAgentAgentEndpointHumanInputConfig), fullyQualifiedName: "oci.generativeAiAgentAgentEndpoint.GenerativeAiAgentAgentEndpointHumanInputConfig")]
        internal sealed class _Proxy : DeputyBase, oci.GenerativeAiAgentAgentEndpoint.IGenerativeAiAgentAgentEndpointHumanInputConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/generative_ai_agent_agent_endpoint#should_enable_human_input GenerativeAiAgentAgentEndpoint#should_enable_human_input}.</summary>
            [JsiiProperty(name: "shouldEnableHumanInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object ShouldEnableHumanInput
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
