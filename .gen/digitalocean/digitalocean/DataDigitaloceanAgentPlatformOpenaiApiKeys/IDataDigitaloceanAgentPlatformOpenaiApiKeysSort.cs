using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformOpenaiApiKeys
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanAgentPlatformOpenaiApiKeysSort), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformOpenaiApiKeys.DataDigitaloceanAgentPlatformOpenaiApiKeysSort")]
    public interface IDataDigitaloceanAgentPlatformOpenaiApiKeysSort
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_openai_api_keys#key DataDigitaloceanAgentPlatformOpenaiApiKeys#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_openai_api_keys#direction DataDigitaloceanAgentPlatformOpenaiApiKeys#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanAgentPlatformOpenaiApiKeysSort), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformOpenaiApiKeys.DataDigitaloceanAgentPlatformOpenaiApiKeysSort")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanAgentPlatformOpenaiApiKeys.IDataDigitaloceanAgentPlatformOpenaiApiKeysSort
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_openai_api_keys#key DataDigitaloceanAgentPlatformOpenaiApiKeys#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.105.0/docs/data-sources/agent_platform_openai_api_keys#direction DataDigitaloceanAgentPlatformOpenaiApiKeys#direction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
