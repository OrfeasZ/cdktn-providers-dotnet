using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMonitoringAlarmSuppressions
{
    [JsiiClass(nativeType: typeof(oci.DataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "alarmSuppressionTarget", typeJson: "{\"fqn\":\"oci.dataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsAlarmSuppressionTargetList\"}")]
        public virtual oci.DataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsAlarmSuppressionTargetList AlarmSuppressionTarget
        {
            get => GetInstanceProperty<oci.DataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsAlarmSuppressionTargetList>()!;
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

        [JsiiProperty(name: "dimensions", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap Dimensions
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Level
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suppressionConditions", typeJson: "{\"fqn\":\"oci.dataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsSuppressionConditionsList\"}")]
        public virtual oci.DataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsSuppressionConditionsList SuppressionConditions
        {
            get => GetInstanceProperty<oci.DataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItemsSuppressionConditionsList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSuppressFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSuppressFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeSuppressUntil", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeSuppressUntil
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciMonitoringAlarmSuppressions.DataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciMonitoringAlarmSuppressions.IDataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciMonitoringAlarmSuppressions.IDataOciMonitoringAlarmSuppressionsAlarmSuppressionCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
