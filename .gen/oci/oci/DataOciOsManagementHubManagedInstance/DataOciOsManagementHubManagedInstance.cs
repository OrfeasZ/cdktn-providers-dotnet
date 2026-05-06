using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagedInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance oci_os_management_hub_managed_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstance), fullyQualifiedName: "oci.dataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceConfig\"}}]")]
    public class DataOciOsManagementHubManagedInstance : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance oci_os_management_hub_managed_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOsManagementHubManagedInstance(Constructs.Construct scope, string id, oci.DataOciOsManagementHubManagedInstance.IDataOciOsManagementHubManagedInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOsManagementHubManagedInstance.IDataOciOsManagementHubManagedInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagedInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagedInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOsManagementHubManagedInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOsManagementHubManagedInstance to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOsManagementHubManagedInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOsManagementHubManagedInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOsManagementHubManagedInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_managed_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOsManagementHubManagedInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOsManagementHubManagedInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstance))!;

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

        [JsiiProperty(name: "autonomousSettings", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceAutonomousSettingsList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceAutonomousSettingsList AutonomousSettings
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceAutonomousSettingsList>()!;
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

        [JsiiProperty(name: "lifecycleEnvironment", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceLifecycleEnvironmentList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceLifecycleEnvironmentList LifecycleEnvironment
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceLifecycleEnvironmentList>()!;
        }

        [JsiiProperty(name: "lifecycleStage", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceLifecycleStageList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceLifecycleStageList LifecycleStage
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceLifecycleStageList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceGroup", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceManagedInstanceGroupList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceManagedInstanceGroupList ManagedInstanceGroup
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceManagedInstanceGroupList>()!;
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

        [JsiiProperty(name: "softwareSources", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceSoftwareSourcesList\"}")]
        public virtual oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceSoftwareSourcesList SoftwareSources
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagedInstance.DataOciOsManagementHubManagedInstanceSoftwareSourcesList>()!;
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
        [JsiiProperty(name: "managedInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
