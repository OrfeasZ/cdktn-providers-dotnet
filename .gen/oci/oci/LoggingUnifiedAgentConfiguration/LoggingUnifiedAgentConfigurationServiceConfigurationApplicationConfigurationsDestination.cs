using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiByValue(fqn: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsDestination")]
    public class LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsDestination : oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#compartment_id LoggingUnifiedAgentConfiguration#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#metrics_namespace LoggingUnifiedAgentConfiguration#metrics_namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricsNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MetricsNamespace
        {
            get;
            set;
        }
    }
}
