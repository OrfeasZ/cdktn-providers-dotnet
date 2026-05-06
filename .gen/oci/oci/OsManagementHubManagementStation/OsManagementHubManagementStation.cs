using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OsManagementHubManagementStation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station oci_os_management_hub_management_station}.</summary>
    [JsiiClass(nativeType: typeof(oci.OsManagementHubManagementStation.OsManagementHubManagementStation), fullyQualifiedName: "oci.osManagementHubManagementStation.OsManagementHubManagementStation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationConfig\"}}]")]
    public class OsManagementHubManagementStation : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station oci_os_management_hub_management_station} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public OsManagementHubManagementStation(Constructs.Construct scope, string id, oci.OsManagementHubManagementStation.IOsManagementHubManagementStationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.OsManagementHubManagementStation.IOsManagementHubManagementStationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagementStation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OsManagementHubManagementStation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a OsManagementHubManagementStation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the OsManagementHubManagementStation to import.</param>
        /// <param name="importFromId">The id of the existing OsManagementHubManagementStation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the OsManagementHubManagementStation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the OsManagementHubManagementStation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/os_management_hub_management_station#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing OsManagementHubManagementStation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the OsManagementHubManagementStation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.OsManagementHubManagementStation.OsManagementHubManagementStation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMirror", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationMirror\"}}]")]
        public virtual void PutMirror(oci.OsManagementHubManagementStation.IOsManagementHubManagementStationMirror @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagementStation.IOsManagementHubManagementStationMirror)}, new object[]{@value});
        }

        [JsiiMethod(name: "putProxy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationProxy\"}}]")]
        public virtual void PutProxy(oci.OsManagementHubManagementStation.IOsManagementHubManagementStationProxy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagementStation.IOsManagementHubManagementStationProxy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.OsManagementHubManagementStation.IOsManagementHubManagementStationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OsManagementHubManagementStation.IOsManagementHubManagementStationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsAutoConfigEnabled")]
        public virtual void ResetIsAutoConfigEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRefreshTrigger")]
        public virtual void ResetRefreshTrigger()
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
        = GetStaticProperty<string>(typeof(oci.OsManagementHubManagementStation.OsManagementHubManagementStation))!;

        [JsiiProperty(name: "health", typeJson: "{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationHealthList\"}")]
        public virtual oci.OsManagementHubManagementStation.OsManagementHubManagementStationHealthList Health
        {
            get => GetInstanceProperty<oci.OsManagementHubManagementStation.OsManagementHubManagementStationHealthList>()!;
        }

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedInstanceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mirror", typeJson: "{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationMirrorOutputReference\"}")]
        public virtual oci.OsManagementHubManagementStation.OsManagementHubManagementStationMirrorOutputReference Mirror
        {
            get => GetInstanceProperty<oci.OsManagementHubManagementStation.OsManagementHubManagementStationMirrorOutputReference>()!;
        }

        [JsiiProperty(name: "mirrorCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MirrorCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mirrorPackageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MirrorPackageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mirrorSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MirrorSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mirrorStorageAvailableSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MirrorStorageAvailableSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mirrorStorageSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MirrorStorageSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mirrorSyncStatus", typeJson: "{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationMirrorSyncStatusList\"}")]
        public virtual oci.OsManagementHubManagementStation.OsManagementHubManagementStationMirrorSyncStatusList MirrorSyncStatus
        {
            get => GetInstanceProperty<oci.OsManagementHubManagementStation.OsManagementHubManagementStationMirrorSyncStatusList>()!;
        }

        [JsiiProperty(name: "mirrorUniquePackageCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MirrorUniquePackageCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "overallPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OverallPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "overallState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverallState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerManagementStations", typeJson: "{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationPeerManagementStationsList\"}")]
        public virtual oci.OsManagementHubManagementStation.OsManagementHubManagementStationPeerManagementStationsList PeerManagementStations
        {
            get => GetInstanceProperty<oci.OsManagementHubManagementStation.OsManagementHubManagementStationPeerManagementStationsList>()!;
        }

        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxy", typeJson: "{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationProxyOutputReference\"}")]
        public virtual oci.OsManagementHubManagementStation.OsManagementHubManagementStationProxyOutputReference Proxy
        {
            get => GetInstanceProperty<oci.OsManagementHubManagementStation.OsManagementHubManagementStationProxyOutputReference>()!;
        }

        [JsiiProperty(name: "scheduledJobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScheduledJobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationTimeoutsOutputReference\"}")]
        public virtual oci.OsManagementHubManagementStation.OsManagementHubManagementStationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.OsManagementHubManagementStation.OsManagementHubManagementStationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "totalMirrors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalMirrors
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
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
        [JsiiProperty(name: "isAutoConfigEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsAutoConfigEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mirrorInput", typeJson: "{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationMirror\"}", isOptional: true)]
        public virtual oci.OsManagementHubManagementStation.IOsManagementHubManagementStationMirror? MirrorInput
        {
            get => GetInstanceProperty<oci.OsManagementHubManagementStation.IOsManagementHubManagementStationMirror?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "proxyInput", typeJson: "{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationProxy\"}", isOptional: true)]
        public virtual oci.OsManagementHubManagementStation.IOsManagementHubManagementStationProxy? ProxyInput
        {
            get => GetInstanceProperty<oci.OsManagementHubManagementStation.IOsManagementHubManagementStationProxy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "refreshTriggerInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RefreshTriggerInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.osManagementHubManagementStation.OsManagementHubManagementStationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
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

        [JsiiProperty(name: "isAutoConfigEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsAutoConfigEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "refreshTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefreshTrigger
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
