using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagedInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AgentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autonomousSettings", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsAutonomousSettingsList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsAutonomousSettingsList AutonomousSettings
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsAutonomousSettingsList>()!;
        }

        [JsiiProperty(name: "bugUpdatesAvailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BugUpdatesAvailable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "enhancementUpdatesAvailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EnhancementUpdatesAvailable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "installedPackages", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstalledPackages
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "installedWindowsUpdates", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstalledWindowsUpdates
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isManagedByAutonomousLinux", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsManagedByAutonomousLinux
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isManagementStation", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsManagementStation
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isRebootRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsRebootRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "kspliceEffectiveKernelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KspliceEffectiveKernelVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleEnvironment", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsLifecycleEnvironmentList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsLifecycleEnvironmentList LifecycleEnvironment
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsLifecycleEnvironmentList>()!;
        }

        [JsiiProperty(name: "lifecycleStage", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsLifecycleStageList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsLifecycleStageList LifecycleStage
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsLifecycleStageList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceGroup", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsManagedInstanceGroupList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsManagedInstanceGroupList ManagedInstanceGroup
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsManagedInstanceGroupList>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notificationTopicId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationTopicId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osFamily", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsFamily
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osKernelVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsKernelVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "otherUpdatesAvailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OtherUpdatesAvailable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "primaryManagementStationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryManagementStationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Profile
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "profileVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheduledJobCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScheduledJobCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "secondaryManagementStationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryManagementStationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityUpdatesAvailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecurityUpdatesAvailable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softwareSources", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsSoftwareSourcesList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsSoftwareSourcesList SoftwareSources
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItemsSoftwareSourcesList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenancyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastBoot", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastBoot
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastCheckin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastCheckin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatesAvailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UpdatesAvailable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "workRequestCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WorkRequestCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstances.DataOciOsManagementHubManagedInstancesManagedInstanceCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubManagedInstances.IDataOciOsManagementHubManagedInstancesManagedInstanceCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstances.IDataOciOsManagementHubManagedInstancesManagedInstanceCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
