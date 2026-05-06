using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciStackMonitoringMonitoringTemplateAlarmConditions
{
    [JsiiClass(nativeType: typeof(oci.DataOciStackMonitoringMonitoringTemplateAlarmConditions.DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciStackMonitoringMonitoringTemplateAlarmConditions.DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compositeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompositeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conditions", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoringTemplateAlarmConditions.DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsConditionsList\"}")]
        public virtual oci.DataOciStackMonitoringMonitoringTemplateAlarmConditions.DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsConditionsList Conditions
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoringTemplateAlarmConditions.DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItemsConditionsList>()!;
        }

        [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConditionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metricName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MetricName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "monitoringTemplateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonitoringTemplateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciStackMonitoringMonitoringTemplateAlarmConditions.DataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciStackMonitoringMonitoringTemplateAlarmConditions.IDataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciStackMonitoringMonitoringTemplateAlarmConditions.IDataOciStackMonitoringMonitoringTemplateAlarmConditionsAlarmConditionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
