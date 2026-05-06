using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMonitoredResourceTask
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMonitoredResourceTaskTaskDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMonitoredResourceTaskTaskDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMonitoredResourceTaskTaskDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMonitoredResourceTaskTaskDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityProxyMetricCollectionInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AvailabilityProxyMetricCollectionInterval
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "availabilityProxyMetrics", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AvailabilityProxyMetrics
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "consolePathPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsolePathPrefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalIdMapping", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalIdMapping
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "handlerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HandlerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isEnable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleStatusMappingsForUpStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LifecycleStatusMappingsForUpStatus
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "receiverProperties", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsReceiverPropertiesList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsReceiverPropertiesList ReceiverProperties
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsReceiverPropertiesList>()!;
        }

        [JsiiProperty(name: "resourceGroup", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroup
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceNameFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceNameFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceNameMapping", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceNameMapping
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTypeFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTypeMapping", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeMapping
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTypesConfiguration", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationList ResourceTypesConfiguration
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetailsResourceTypesConfigurationList>()!;
        }

        [JsiiProperty(name: "serviceBaseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceBaseUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shouldUseMetricsFlowForStatus", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ShouldUseMetricsFlowForStatus
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTask.DataOciStackMonitoringMonitoredResourceTaskTaskDetails\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTask.IDataOciStackMonitoringMonitoredResourceTaskTaskDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTask.IDataOciStackMonitoringMonitoredResourceTaskTaskDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
