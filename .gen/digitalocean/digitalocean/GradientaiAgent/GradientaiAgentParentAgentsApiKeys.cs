using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.GradientaiAgent
{
    [JsiiByValue(fqn: "digitalocean.gradientaiAgent.GradientaiAgentParentAgentsApiKeys")]
    public class GradientaiAgentParentAgentsApiKeys : digitalocean.GradientaiAgent.IGradientaiAgentParentAgentsApiKeys
    {
        /// <summary>API Key value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/gradientai_agent#api_key GradientaiAgent#api_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiKey
        {
            get;
            set;
        }
    }
}
