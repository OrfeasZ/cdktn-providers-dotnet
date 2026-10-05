using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformAgents
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsSort")]
    public interface IDataDigitaloceanAgentPlatformAgentsSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agents#key DataDigitaloceanAgentPlatformAgents#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agents#direction DataDigitaloceanAgentPlatformAgents#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanAgentPlatformAgentsSort), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformAgents.DataDigitaloceanAgentPlatformAgentsSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanAgentPlatformAgents.IDataDigitaloceanAgentPlatformAgentsSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agents#key DataDigitaloceanAgentPlatformAgents#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.104.0/docs/data-sources/agent_platform_agents#direction DataDigitaloceanAgentPlatformAgents#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
