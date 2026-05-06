using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiInterface(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource")]
    public interface ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource
    {
        /// <summary>record_input block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#record_input LoggingUnifiedAgentConfiguration#record_input}
        /// </remarks>
        [JsiiProperty(name: "recordInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput\"}")]
        oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput RecordInput
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#type LoggingUnifiedAgentConfiguration#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#metrics LoggingUnifiedAgentConfiguration#metrics}.</summary>
        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Metrics
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource")]
        internal sealed class _Proxy : DeputyBase, oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>record_input block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#record_input LoggingUnifiedAgentConfiguration#record_input}
            /// </remarks>
            [JsiiProperty(name: "recordInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput\"}")]
            public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput RecordInput
            {
                get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#type LoggingUnifiedAgentConfiguration#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#metrics LoggingUnifiedAgentConfiguration#metrics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Metrics
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
