using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiInterface(nativeType: typeof(IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming")]
    public interface IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#stream_id ApmTracesScheduledQuery#stream_id}.</summary>
        [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StreamId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming")]
        internal sealed class _Proxy : DeputyBase, oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#stream_id ApmTracesScheduledQuery#stream_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "streamId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StreamId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
