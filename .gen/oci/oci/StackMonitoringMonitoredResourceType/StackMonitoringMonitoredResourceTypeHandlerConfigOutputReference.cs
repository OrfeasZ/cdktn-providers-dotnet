using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringMonitoredResourceType
{
    [JsiiClass(nativeType: typeof(oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigOutputReference), fullyQualifiedName: "oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class StackMonitoringMonitoredResourceTypeHandlerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public StackMonitoringMonitoredResourceTypeHandlerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourceTypeHandlerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StackMonitoringMonitoredResourceTypeHandlerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "collectdResourceNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigCollectdResourceNameConfigList\"}")]
        public virtual oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigCollectdResourceNameConfigList CollectdResourceNameConfig
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigCollectdResourceNameConfigList>()!;
        }

        [JsiiProperty(name: "collectorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CollectorTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "handlerProperties", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigHandlerPropertiesList\"}")]
        public virtual oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigHandlerPropertiesList HandlerProperties
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigHandlerPropertiesList>()!;
        }

        [JsiiProperty(name: "metricMappings", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigMetricMappingsList\"}")]
        public virtual oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigMetricMappingsList MetricMappings
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigMetricMappingsList>()!;
        }

        [JsiiProperty(name: "metricNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigMetricNameConfigList\"}")]
        public virtual oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigMetricNameConfigList MetricNameConfig
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigMetricNameConfigList>()!;
        }

        [JsiiProperty(name: "metricUploadIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricUploadIntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "telegrafResourceNameConfig", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigTelegrafResourceNameConfigList\"}")]
        public virtual oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigTelegrafResourceNameConfigList TelegrafResourceNameConfig
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfigTelegrafResourceNameConfigList>()!;
        }

        [JsiiProperty(name: "telemetryResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TelemetryResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.stackMonitoringMonitoredResourceType.StackMonitoringMonitoredResourceTypeHandlerConfig\"}", isOptional: true)]
        public virtual oci.StackMonitoringMonitoredResourceType.IStackMonitoringMonitoredResourceTypeHandlerConfig? InternalValue
        {
            get => GetInstanceProperty<oci.StackMonitoringMonitoredResourceType.IStackMonitoringMonitoredResourceTypeHandlerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
