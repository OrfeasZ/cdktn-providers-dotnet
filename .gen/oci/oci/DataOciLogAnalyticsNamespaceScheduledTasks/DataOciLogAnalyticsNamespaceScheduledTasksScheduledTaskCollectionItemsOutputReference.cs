using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciLogAnalyticsNamespaceScheduledTasks
{
    [JsiiClass(nativeType: typeof(oci.DataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsActionList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsActionList Action
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsActionList>()!;
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

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Namespace
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numOccurrences", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NumOccurrences
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "savedSearchId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SavedSearchId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledTaskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledTaskId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedules", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsSchedulesList\"}")]
        public virtual oci.DataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsSchedulesList Schedules
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItemsSchedulesList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskType
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

        [JsiiProperty(name: "workRequestId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkRequestId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciLogAnalyticsNamespaceScheduledTasks.DataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciLogAnalyticsNamespaceScheduledTasks.IDataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciLogAnalyticsNamespaceScheduledTasks.IDataOciLogAnalyticsNamespaceScheduledTasksScheduledTaskCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
