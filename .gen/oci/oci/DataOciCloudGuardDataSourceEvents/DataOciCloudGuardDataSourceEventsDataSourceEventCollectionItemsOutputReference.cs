using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudGuardDataSourceEvents
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudGuardDataSourceEvents.DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciCloudGuardDataSourceEvents.DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "comments", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Comments
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataSourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "eventInfo", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDataSourceEvents.DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsEventInfoList\"}")]
        public virtual oci.DataOciCloudGuardDataSourceEvents.DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsEventInfoList EventInfo
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDataSourceEvents.DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItemsEventInfoList>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudGuardDataSourceEvents.DataOciCloudGuardDataSourceEventsDataSourceEventCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciCloudGuardDataSourceEvents.IDataOciCloudGuardDataSourceEventsDataSourceEventCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudGuardDataSourceEvents.IDataOciCloudGuardDataSourceEventsDataSourceEventCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
