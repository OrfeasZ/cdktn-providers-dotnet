using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMonitoredResourceTypes
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalNamespaceMap", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalNamespaceMap
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "availabilityMetricsConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsAvailabilityMetricsConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsAvailabilityMetricsConfigList AvailabilityMetricsConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsAvailabilityMetricsConfigList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "handlerConfig", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigList HandlerConfig
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsHandlerConfigList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isSystemDefined", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSystemDefined
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItemsMetadataList>()!;
        }

        [JsiiProperty(name: "metricNamespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricNamespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceCategory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoredResourceTypes.DataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMonitoredResourceTypes.IDataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoredResourceTypes.IDataOciStackMonitoringMonitoredResourceTypesMonitoredResourceTypesCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
