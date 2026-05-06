using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreInstanceMaintenanceEvents
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreInstanceMaintenanceEvents.DataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEventsOutputReference), fullyQualifiedName: "oci.dataOciCoreInstanceMaintenanceEvents.DataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEventsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEventsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEventsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEventsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEventsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalDetails
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "alternativeResolutionAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AlternativeResolutionAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "alternativeResolutionActions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AlternativeResolutionActions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "canDeleteLocalStorage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CanDeleteLocalStorage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "canReschedule", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CanReschedule
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "correlationToken", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CorrelationToken
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
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

        [JsiiProperty(name: "estimatedDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EstimatedDuration
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

        [JsiiProperty(name: "instanceAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceMaintenanceEventId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceMaintenanceEventId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceCategory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceCategory
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startWindowDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartWindowDuration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeHardDueDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeHardDueDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeWindowStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeWindowStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreInstanceMaintenanceEvents.DataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEvents\"}", isOptional: true)]
        public virtual oci.DataOciCoreInstanceMaintenanceEvents.IDataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEvents? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreInstanceMaintenanceEvents.IDataOciCoreInstanceMaintenanceEventsInstanceMaintenanceEvents?>();
            set => SetInstanceProperty(value);
        }
    }
}
