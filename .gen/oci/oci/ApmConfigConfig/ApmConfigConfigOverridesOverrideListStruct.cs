using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmConfigConfig
{
    [JsiiByValue(fqn: "oci.apmConfigConfig.ApmConfigConfigOverridesOverrideListStruct")]
    public class ApmConfigConfigOverridesOverrideListStruct : oci.ApmConfigConfig.IApmConfigConfigOverridesOverrideListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#agent_filter ApmConfigConfig#agent_filter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "agentFilter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AgentFilter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_config_config#override_map ApmConfigConfig#override_map}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overrideMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? OverrideMap
        {
            get;
            set;
        }
    }
}
