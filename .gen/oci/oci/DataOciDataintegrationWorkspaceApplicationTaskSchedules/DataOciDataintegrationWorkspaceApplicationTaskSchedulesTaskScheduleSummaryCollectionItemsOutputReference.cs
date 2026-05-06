using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules
{
    [JsiiClass(nativeType: typeof(oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "applicationKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplicationKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configProviderDelegate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigProviderDelegate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endTimeMillis", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndTimeMillis
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expectedDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpectedDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "expectedDurationUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedDurationUnit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Identifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isBackfillEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBackfillEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isConcurrentAllowed", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsConcurrentAllowed
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastRunDetails", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsLastRunDetailsList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsLastRunDetailsList LastRunDetails
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsLastRunDetailsList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsMetadataList Metadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsMetadataList>()!;
        }

        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextRunTimeMillis", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextRunTimeMillis
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numberOfRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfRetries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "objectStatus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectStatus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ObjectVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsParentRefList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsParentRefList ParentRef
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsParentRefList>()!;
        }

        [JsiiProperty(name: "registryMetadata", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsRegistryMetadataList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsRegistryMetadataList RegistryMetadata
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsRegistryMetadataList>()!;
        }

        [JsiiProperty(name: "retryAttempts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryAttempts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "retryDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetryDelay
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "retryDelayUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetryDelayUnit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduleRef", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsScheduleRefList\"}")]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsScheduleRefList ScheduleRef
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItemsScheduleRefList>()!;
        }

        [JsiiProperty(name: "startTimeMillis", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTimeMillis
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workspaceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDataintegrationWorkspaceApplicationTaskSchedules.DataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.IDataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDataintegrationWorkspaceApplicationTaskSchedules.IDataOciDataintegrationWorkspaceApplicationTaskSchedulesTaskScheduleSummaryCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
