using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciAuditEvents
{
    [JsiiClass(nativeType: typeof(oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataOutputReference), fullyQualifiedName: "oci.dataOciAuditEvents.DataOciAuditEventsAuditEventsDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciAuditEventsAuditEventsDataOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciAuditEventsAuditEventsDataOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciAuditEventsAuditEventsDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciAuditEventsAuditEventsDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "additionalDetails", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap AdditionalDetails
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "eventGroupingId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventGroupingId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"oci.dataOciAuditEvents.DataOciAuditEventsAuditEventsDataIdentityList\"}")]
        public virtual oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataIdentityList Identity
        {
            get => GetInstanceProperty<oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataIdentityList>()!;
        }

        [JsiiProperty(name: "request", typeJson: "{\"fqn\":\"oci.dataOciAuditEvents.DataOciAuditEventsAuditEventsDataRequestList\"}")]
        public virtual oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataRequestList Request
        {
            get => GetInstanceProperty<oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataRequestList>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"oci.dataOciAuditEvents.DataOciAuditEventsAuditEventsDataResponseList\"}")]
        public virtual oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataResponseList Response
        {
            get => GetInstanceProperty<oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataResponseList>()!;
        }

        [JsiiProperty(name: "stateChange", typeJson: "{\"fqn\":\"oci.dataOciAuditEvents.DataOciAuditEventsAuditEventsDataStateChangeList\"}")]
        public virtual oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataStateChangeList StateChange
        {
            get => GetInstanceProperty<oci.DataOciAuditEvents.DataOciAuditEventsAuditEventsDataStateChangeList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciAuditEvents.DataOciAuditEventsAuditEventsData\"}", isOptional: true)]
        public virtual oci.DataOciAuditEvents.IDataOciAuditEventsAuditEventsData? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciAuditEvents.IDataOciAuditEventsAuditEventsData?>();
            set => SetInstanceProperty(value);
        }
    }
}
