using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiInterface(nativeType: typeof(IApmConfigConfigOverridesOverrideListStruct), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStruct")]
    public interface IApmConfigConfigOverridesOverrideListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#agent_filter ApmConfigConfig#agent_filter}.</summary>
        [JsiiProperty(name: "agentFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#override_map ApmConfigConfig#override_map}.</summary>
        [JsiiProperty(name: "overrideMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? OverrideMap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmConfigConfigOverridesOverrideListStruct), fullyQualifiedName: "oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.ApmConfigConfig.IApmConfigConfigOverridesOverrideListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#agent_filter ApmConfigConfig#agent_filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentFilter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#override_map ApmConfigConfig#override_map}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overrideMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? OverrideMap
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
