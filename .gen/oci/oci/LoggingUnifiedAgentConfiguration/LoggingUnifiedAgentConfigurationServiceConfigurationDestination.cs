using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestination")]
    public class LoggingUnifiedAgentConfigurationServiceConfigurationDestination : oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestination
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#log_object_id LoggingUnifiedAgentConfiguration#log_object_id}.</summary>
        [JsiiProperty(name: "logObjectId", typeJson: "{\"primitive\":\"string\"}")]
        public string LogObjectId
        {
            get;
            set;
        }

        /// <summary>operational_metrics_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#operational_metrics_configuration LoggingUnifiedAgentConfiguration#operational_metrics_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "operationalMetricsConfiguration", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfiguration\"}", isOptional: true)]
        public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfiguration? OperationalMetricsConfiguration
        {
            get;
            set;
        }
    }
}
