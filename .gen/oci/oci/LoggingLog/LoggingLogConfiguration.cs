using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingLog
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.loggingLog.LoggingLogConfiguration")]
    public class LoggingLogConfiguration : oci.LoggingLog.ILoggingLogConfiguration
    {
        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_log#source LoggingLog#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.loggingLog.LoggingLogConfigurationSource\"}")]
        public oci.LoggingLog.ILoggingLogConfigurationSource Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_log#compartment_id LoggingLog#compartment_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompartmentId
        {
            get;
            set;
        }
    }
}
