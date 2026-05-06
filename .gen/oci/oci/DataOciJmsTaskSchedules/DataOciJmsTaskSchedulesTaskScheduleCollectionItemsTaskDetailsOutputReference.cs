using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsTaskSchedules
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsOutputReference), fullyQualifiedName: "oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsAddInstallationSiteTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsAddInstallationSiteTaskRequestList AddInstallationSiteTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsAddInstallationSiteTaskRequestList>()!;
        }

        [JsiiProperty(name: "cryptoTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsCryptoTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsCryptoTaskRequestList CryptoTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsCryptoTaskRequestList>()!;
        }

        [JsiiProperty(name: "deployedApplicationMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsDeployedApplicationMigrationTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsDeployedApplicationMigrationTaskRequestList DeployedApplicationMigrationTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsDeployedApplicationMigrationTaskRequestList>()!;
        }

        [JsiiProperty(name: "javaMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsJavaMigrationTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsJavaMigrationTaskRequestList JavaMigrationTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsJavaMigrationTaskRequestList>()!;
        }

        [JsiiProperty(name: "jfrTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsJfrTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsJfrTaskRequestList JfrTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsJfrTaskRequestList>()!;
        }

        [JsiiProperty(name: "performanceTuningTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsPerformanceTuningTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsPerformanceTuningTaskRequestList PerformanceTuningTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsPerformanceTuningTaskRequestList>()!;
        }

        [JsiiProperty(name: "removeInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsRemoveInstallationSiteTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsRemoveInstallationSiteTaskRequestList RemoveInstallationSiteTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsRemoveInstallationSiteTaskRequestList>()!;
        }

        [JsiiProperty(name: "scanJavaServerTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsScanJavaServerTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsScanJavaServerTaskRequestList ScanJavaServerTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsScanJavaServerTaskRequestList>()!;
        }

        [JsiiProperty(name: "scanLibraryTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsScanLibraryTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsScanLibraryTaskRequestList ScanLibraryTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetailsScanLibraryTaskRequestList>()!;
        }

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedules.DataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetails\"}", isOptional: true)]
        public virtual oci.DataOciJmsTaskSchedules.IDataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedules.IDataOciJmsTaskSchedulesTaskScheduleCollectionItemsTaskDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
