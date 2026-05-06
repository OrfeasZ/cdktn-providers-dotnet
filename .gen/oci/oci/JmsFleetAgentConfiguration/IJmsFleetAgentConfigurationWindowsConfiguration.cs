using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsFleetAgentConfiguration
{
    [JsiiInterface(nativeType: typeof(IJmsFleetAgentConfigurationWindowsConfiguration), fullyQualifiedName: "oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfiguration")]
    public interface IJmsFleetAgentConfigurationWindowsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#exclude_paths JmsFleetAgentConfiguration#exclude_paths}.</summary>
        [JsiiProperty(name: "excludePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ExcludePaths
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#include_paths JmsFleetAgentConfiguration#include_paths}.</summary>
        [JsiiProperty(name: "includePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IncludePaths
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsFleetAgentConfigurationWindowsConfiguration), fullyQualifiedName: "oci.jmsFleetAgentConfiguration.JmsFleetAgentConfigurationWindowsConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.JmsFleetAgentConfiguration.IJmsFleetAgentConfigurationWindowsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#exclude_paths JmsFleetAgentConfiguration#exclude_paths}.</summary>
            [JsiiProperty(name: "excludePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ExcludePaths
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_fleet_agent_configuration#include_paths JmsFleetAgentConfiguration#include_paths}.</summary>
            [JsiiProperty(name: "includePaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IncludePaths
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
