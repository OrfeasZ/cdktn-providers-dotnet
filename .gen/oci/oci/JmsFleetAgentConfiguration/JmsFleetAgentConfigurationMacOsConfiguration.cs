using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAgentConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationMacOsConfiguration")]
    public class JmsFleetAgentConfigurationMacOsConfiguration : oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationMacOsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#exclude_paths JmsFleetAgentConfiguration#exclude_paths}.</summary>
        [JsiiProperty(name: "excludePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] ExcludePaths
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#include_paths JmsFleetAgentConfiguration#include_paths}.</summary>
        [JsiiProperty(name: "includePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] IncludePaths
        {
            get;
            set;
        }
    }
}
