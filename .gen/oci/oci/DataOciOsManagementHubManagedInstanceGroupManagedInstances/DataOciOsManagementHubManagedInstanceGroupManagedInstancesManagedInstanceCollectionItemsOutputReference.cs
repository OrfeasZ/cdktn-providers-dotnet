using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "autonomousSettings", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsAutonomousSettingsList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsAutonomousSettingsList AutonomousSettings
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsAutonomousSettingsList>()!;
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "lifecycleEnvironment", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsLifecycleEnvironmentList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsLifecycleEnvironmentList LifecycleEnvironment
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsLifecycleEnvironmentList>()!;
        }

        [JsiiProperty(name: "lifecycleStage", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsLifecycleStageList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsLifecycleStageList LifecycleStage
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsLifecycleStageList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceGroup", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsManagedInstanceGroupList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsManagedInstanceGroupList ManagedInstanceGroup
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItemsManagedInstanceGroupList>()!;
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

        [JsiiProperty(name: "timeLastBoot", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastBoot
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatesAvailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UpdatesAvailable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstanceGroupManagedInstances.DataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.IDataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstanceGroupManagedInstances.IDataOciOsManagementHubManagedInstanceGroupManagedInstancesManagedInstanceCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
