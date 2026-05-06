using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMonitoredResourceType
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMonitoredResourceTypeHandlerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMonitoredResourceTypeHandlerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMonitoredResourceTypeHandlerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMonitoredResourceTypeHandlerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "collectdResourceNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigCollectdResourceNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigCollectdResourceNameConfigList CollectdResourceNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigCollectdResourceNameConfigList>()!;
        }

        [JsiiProperty(name: "collectorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CollectorTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "handlerProperties", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigHandlerPropertiesList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigHandlerPropertiesList HandlerProperties
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigHandlerPropertiesList>()!;
        }

        [JsiiProperty(name: "metricMappings", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigMetricMappingsList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigMetricMappingsList MetricMappings
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigMetricMappingsList>()!;
        }

        [JsiiProperty(name: "metricNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigMetricNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigMetricNameConfigList MetricNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigMetricNameConfigList>()!;
        }

        [JsiiProperty(name: "metricUploadIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricUploadIntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "telegrafResourceNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigTelegrafResourceNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigTelegrafResourceNameConfigList TelegrafResourceNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfigTelegrafResourceNameConfigList>()!;
        }

        [JsiiProperty(name: "telemetryResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TelemetryResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceType.DataOciStackMonitoringMonitoredResourceTypeHandlerConfig\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMonitoredResourceType.IDataOciStackMonitoringMonitoredResourceTypeHandlerConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceType.IDataOciStackMonitoringMonitoredResourceTypeHandlerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
