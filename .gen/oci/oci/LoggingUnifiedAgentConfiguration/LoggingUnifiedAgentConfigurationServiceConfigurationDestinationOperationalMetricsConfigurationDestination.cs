using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationDestination")]
    public class LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationDestination : oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#compartment_id LoggingUnifiedAgentConfiguration#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public string CompartmentId
        {
            get;
            set;
        }
    }
}
