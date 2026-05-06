using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiClass(nativeType: typeof(oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceOutputReference), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRecordInput", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput\"}}]")]
        public virtual void PutRecordInput(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMetrics")]
        public virtual void ResetMetrics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "recordInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInputOutputReference\"}")]
        public virtual oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInputOutputReference RecordInput
        {
            get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInputOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? MetricsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordInputInput", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput\"}", isOptional: true)]
        public virtual oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput? RecordInputInput
        {
            get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSourceRecordInput?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "metrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Metrics
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource\"}", isOptional: true)]
        public virtual oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource? InternalValue
        {
            get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestinationOperationalMetricsConfigurationSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
