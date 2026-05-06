using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagedInstance
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance oci_os_management_hub_managed_instance}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubManagedInstance.OsManagementHubManagedInstance), fullyQualifiedName: "oci.osManagementHubManagedInstance.OsManagementHubManagedInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceConfig\"}}]")]
    public class OsManagementHubManagedInstance : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance oci_os_management_hub_managed_instance} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubManagedInstance(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstance.IOsManagementHubManagedInstanceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubManagedInstance.IOsManagementHubManagedInstanceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagedInstance(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubManagedInstance resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubManagedInstance to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubManagedInstance that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubManagedInstance to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubManagedInstance to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_managed_instance#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubManagedInstance that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubManagedInstance to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubManagedInstance.OsManagementHubManagedInstance), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAutonomousSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceAutonomousSettings\"}}]")]
        public virtual void PutAutonomousSettings(oci.OsManagementHubManagedInstance.IOsManagementHubManagedInstanceAutonomousSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstance.IOsManagementHubManagedInstanceAutonomousSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubManagedInstance.IOsManagementHubManagedInstanceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagedInstance.IOsManagementHubManagedInstanceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutonomousSettings")]
        public virtual void ResetAutonomousSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotificationTopicId")]
        public virtual void ResetNotificationTopicId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrimaryManagementStationId")]
        public virtual void ResetPrimaryManagementStationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryManagementStationId")]
        public virtual void ResetSecondaryManagementStationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubManagedInstance.OsManagementHubManagedInstance))!;

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

        [JsiiProperty(name: "autonomousSettings", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceAutonomousSettingsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceAutonomousSettingsOutputReference AutonomousSettings
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceAutonomousSettingsOutputReference>()!;
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

        [JsiiProperty(name: "lifecycleEnvironment", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceLifecycleEnvironmentList\"}")]
        public virtual oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceLifecycleEnvironmentList LifecycleEnvironment
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceLifecycleEnvironmentList>()!;
        }

        [JsiiProperty(name: "lifecycleStage", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceLifecycleStageList\"}")]
        public virtual oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceLifecycleStageList LifecycleStage
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceLifecycleStageList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceGroup", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceManagedInstanceGroupList\"}")]
        public virtual oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceManagedInstanceGroupList ManagedInstanceGroup
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceManagedInstanceGroupList>()!;
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

        [JsiiProperty(name: "securityUpdatesAvailable", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SecurityUpdatesAvailable
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "softwareSources", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceSoftwareSourcesList\"}")]
        public virtual oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceSoftwareSourcesList SoftwareSources
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceSoftwareSourcesList>()!;
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

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstance.OsManagementHubManagedInstanceTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "autonomousSettingsInput", typeJson: "{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceAutonomousSettings\"}", isOptional: true)]
        public virtual oci.OsManagementHubManagedInstance.IOsManagementHubManagedInstanceAutonomousSettings? AutonomousSettingsInput
        {
            get => GetInstanceProperty<oci.OsManagementHubManagedInstance.IOsManagementHubManagedInstanceAutonomousSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedInstanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedInstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationTopicIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotificationTopicIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "primaryManagementStationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrimaryManagementStationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryManagementStationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecondaryManagementStationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubManagedInstance.OsManagementHubManagedInstanceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notificationTopicId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationTopicId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "primaryManagementStationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrimaryManagementStationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secondaryManagementStationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondaryManagementStationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
