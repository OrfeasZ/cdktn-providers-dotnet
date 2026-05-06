using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiByValue(fqn: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfiguration")]
    public class ApmTracesScheduledQueryScheduledQueryProcessingConfiguration : oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration
    {
        /// <summary>custom_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#custom_metric ApmTracesScheduledQuery#custom_metric}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customMetric", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric\"}", isOptional: true)]
        public oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric? CustomMetric
        {
            get;
            set;
        }

        /// <summary>object_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#object_storage ApmTracesScheduledQuery#object_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectStorage", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage\"}", isOptional: true)]
        public oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage? ObjectStorage
        {
            get;
            set;
        }

        /// <summary>streaming block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#streaming ApmTracesScheduledQuery#streaming}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streaming", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming\"}", isOptional: true)]
        public oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming? Streaming
        {
            get;
            set;
        }
    }
}
