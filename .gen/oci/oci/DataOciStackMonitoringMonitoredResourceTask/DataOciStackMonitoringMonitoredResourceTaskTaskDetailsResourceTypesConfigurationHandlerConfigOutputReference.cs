using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMonitoredResourceTask
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "collectdResourceNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfigList CollectdResourceNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigCollectdResourceNameConfigList>()!;
        }

        [JsiiProperty(name: "collectorTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CollectorTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "handlerProperties", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigHandlerPropertiesList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigHandlerPropertiesList HandlerProperties
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigHandlerPropertiesList>()!;
        }

        [JsiiProperty(name: "metricMappings", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappingsList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappingsList MetricMappings
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricMappingsList>()!;
        }

        [JsiiProperty(name: "metricNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfigList MetricNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigMetricNameConfigList>()!;
        }

        [JsiiProperty(name: "metricUploadIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricUploadIntervalInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "telegrafResourceNameConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfigList TelegrafResourceNameConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfigTelegrafResourceNameConfigList>()!;
        }

        [JsiiProperty(name: "telemetryResourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TelemetryResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.IDataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.IDataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationHandlerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
