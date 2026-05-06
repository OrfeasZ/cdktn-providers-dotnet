using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMonitoredResourceTypes
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "collectdResourceNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigCollectdResourceNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigCollectdResourceNameConfigList CollectdResourceNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigCollectdResourceNameConfigList>()!;
        }

        [JsiiProperty(name: "collectorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CollectorTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "handlerProperties", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigHandlerPropertiesList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigHandlerPropertiesList HandlerProperties
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigHandlerPropertiesList>()!;
        }

        [JsiiProperty(name: "metricMappings", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigMetricMappingsList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigMetricMappingsList MetricMappings
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigMetricMappingsList>()!;
        }

        [JsiiProperty(name: "metricNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigMetricNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigMetricNameConfigList MetricNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigMetricNameConfigList>()!;
        }

        [JsiiProperty(name: "metricUploadIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricUploadIntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "telegrafResourceNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigTelegrafResourceNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigTelegrafResourceNameConfigList TelegrafResourceNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigTelegrafResourceNameConfigList>()!;
        }

        [JsiiProperty(name: "telemetryResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TelemetryResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfig\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.IDataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.IDataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
