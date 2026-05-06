using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiInterface(nativeType: typeof(IApmTracesScheduledQueryScheduledQueryProcessingConfiguration), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfiguration")]
    public interface IApmTracesScheduledQueryScheduledQueryProcessingConfiguration
    {
        /// <summary>custom_metric block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#custom_metric ApmTracesScheduledQuery#custom_metric}
        /// </remarks>
        [JsiiProperty(name: "customMetric", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric? CustomMetric
        {
            get
            {
                return null;
            }
        }

        /// <summary>object_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#object_storage ApmTracesScheduledQuery#object_storage}
        /// </remarks>
        [JsiiProperty(name: "objectStorage", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage? ObjectStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>streaming block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#streaming ApmTracesScheduledQuery#streaming}
        /// </remarks>
        [JsiiProperty(name: "streaming", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming? Streaming
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmTracesScheduledQueryScheduledQueryProcessingConfiguration), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_metric block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#custom_metric ApmTracesScheduledQuery#custom_metric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customMetric", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric\"}", isOptional: true)]
            public oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric? CustomMetric
            {
                get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric?>();
            }

            /// <summary>object_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#object_storage ApmTracesScheduledQuery#object_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectStorage", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage\"}", isOptional: true)]
            public oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage? ObjectStorage
            {
                get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage?>();
            }

            /// <summary>streaming block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#streaming ApmTracesScheduledQuery#streaming}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "streaming", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming\"}", isOptional: true)]
            public oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming? Streaming
            {
                get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming?>();
            }
        }
    }
}
