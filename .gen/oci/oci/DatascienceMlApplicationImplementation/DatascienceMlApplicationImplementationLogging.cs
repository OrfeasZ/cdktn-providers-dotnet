using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceMlApplicationImplementation
{
    [JsiiByValue(fqn: "oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLogging")]
    public class DatascienceMlApplicationImplementationLogging : oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLogging
    {
        /// <summary>aggregated_instance_view_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_implementation#aggregated_instance_view_log DatascienceMlApplicationImplementation#aggregated_instance_view_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aggregatedInstanceViewLog", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog\"}", isOptional: true)]
        public oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingAggregatedInstanceViewLog? AggregatedInstanceViewLog
        {
            get;
            set;
        }

        /// <summary>implementation_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_implementation#implementation_log DatascienceMlApplicationImplementation#implementation_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "implementationLog", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingImplementationLog\"}", isOptional: true)]
        public oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingImplementationLog? ImplementationLog
        {
            get;
            set;
        }

        /// <summary>trigger_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_ml_application_implementation#trigger_log DatascienceMlApplicationImplementation#trigger_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "triggerLog", typeJson: "{\"fqn\":\"oci.datascienceMlApplicationImplementation.DatascienceMlApplicationImplementationLoggingTriggerLog\"}", isOptional: true)]
        public oci.DatascienceMlApplicationImplementation.IDatascienceMlApplicationImplementationLoggingTriggerLog? TriggerLog
        {
            get;
            set;
        }
    }
}
