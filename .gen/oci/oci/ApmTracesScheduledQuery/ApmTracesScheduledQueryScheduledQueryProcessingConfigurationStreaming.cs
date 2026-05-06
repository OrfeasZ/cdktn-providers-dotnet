using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiByValue(fqn: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming")]
    public class ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming : oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#stream_id ApmTracesScheduledQuery#stream_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StreamId
        {
            get;
            set;
        }
    }
}
