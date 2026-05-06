using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiClass(nativeType: typeof(oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApmTracesScheduledQueryScheduledQueryProcessingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomMetric", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric\"}}]")]
        public virtual void PutCustomMetric(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric)}, new object[]{@value});
        }

        [JsiiMethod(name: "putObjectStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage\"}}]")]
        public virtual void PutObjectStorage(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStreaming", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming\"}}]")]
        public virtual void PutStreaming(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomMetric")]
        public virtual void ResetCustomMetric()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStorage")]
        public virtual void ResetObjectStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreaming")]
        public virtual void ResetStreaming()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customMetric", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetricOutputReference\"}")]
        public virtual oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetricOutputReference CustomMetric
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetricOutputReference>()!;
        }

        [JsiiProperty(name: "objectStorage", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference\"}")]
        public virtual oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference ObjectStorage
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorageOutputReference>()!;
        }

        [JsiiProperty(name: "streaming", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreamingOutputReference\"}")]
        public virtual oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreamingOutputReference Streaming
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreamingOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customMetricInput", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric\"}", isOptional: true)]
        public virtual oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric? CustomMetricInput
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationCustomMetric?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStorageInput", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage\"}", isOptional: true)]
        public virtual oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage? ObjectStorageInput
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationObjectStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamingInput", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming\"}", isOptional: true)]
        public virtual oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming? StreamingInput
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfigurationStreaming?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfiguration\"}", isOptional: true)]
        public virtual oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
