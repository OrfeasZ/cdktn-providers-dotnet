using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciJmsTaskSchedule
{
    [JsiiClass(nativeType: typeof(oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsOutputReference), fullyQualifiedName: "oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciJmsTaskScheduleTaskDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciJmsTaskScheduleTaskDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciJmsTaskScheduleTaskDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciJmsTaskScheduleTaskDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestList AddInstallationSiteTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequestList>()!;
        }

        [JsiiProperty(name: "cryptoTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsCryptoTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsCryptoTaskRequestList CryptoTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsCryptoTaskRequestList>()!;
        }

        [JsiiProperty(name: "deployedApplicationMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestList DeployedApplicationMigrationTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequestList>()!;
        }

        [JsiiProperty(name: "javaMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestList JavaMigrationTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestList>()!;
        }

        [JsiiProperty(name: "jfrTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestList JfrTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsJfrTaskRequestList>()!;
        }

        [JsiiProperty(name: "performanceTuningTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestList PerformanceTuningTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequestList>()!;
        }

        [JsiiProperty(name: "removeInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestList RemoveInstallationSiteTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequestList>()!;
        }

        [JsiiProperty(name: "scanJavaServerTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsScanJavaServerTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsScanJavaServerTaskRequestList ScanJavaServerTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsScanJavaServerTaskRequestList>()!;
        }

        [JsiiProperty(name: "scanLibraryTaskRequest", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsScanLibraryTaskRequestList\"}")]
        public virtual oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsScanLibraryTaskRequestList ScanLibraryTaskRequest
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetailsScanLibraryTaskRequestList>()!;
        }

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciJmsTaskSchedule.DataOciJmsTaskScheduleTaskDetails\"}", isOptional: true)]
        public virtual oci.DataOciJmsTaskSchedule.IDataOciJmsTaskScheduleTaskDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciJmsTaskSchedule.IDataOciJmsTaskScheduleTaskDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
