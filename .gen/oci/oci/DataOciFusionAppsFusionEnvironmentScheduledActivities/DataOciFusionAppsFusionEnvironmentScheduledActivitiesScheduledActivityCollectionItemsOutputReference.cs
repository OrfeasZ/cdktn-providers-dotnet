using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFusionAppsFusionEnvironmentScheduledActivities
{
    [JsiiClass(nativeType: typeof(oci.DataOciFusionAppsFusionEnvironmentScheduledActivities.DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciFusionAppsFusionEnvironmentScheduledActivities.DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "actions", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentScheduledActivities.DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsActionsList\"}")]
        public virtual oci.DataOciFusionAppsFusionEnvironmentScheduledActivities.DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsActionsList Actions
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironmentScheduledActivities.DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItemsActionsList>()!;
        }

        [JsiiProperty(name: "delayInHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DelayInHours
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "fusionEnvironmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FusionEnvironmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runCycle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RunCycle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceAvailability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAvailability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeExpectedFinish", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeExpectedFinish
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeScheduledStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeScheduledStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFusionAppsFusionEnvironmentScheduledActivities.DataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciFusionAppsFusionEnvironmentScheduledActivities.IDataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFusionAppsFusionEnvironmentScheduledActivities.IDataOciFusionAppsFusionEnvironmentScheduledActivitiesScheduledActivityCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
