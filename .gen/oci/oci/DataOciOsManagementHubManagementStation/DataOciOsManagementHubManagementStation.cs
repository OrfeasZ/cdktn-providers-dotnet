using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubManagementStation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_management_station oci_os_management_hub_management_station}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStation), fullyQualifiedName: "oci.dataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationConfig\"}}]")]
    public class DataOciOsManagementHubManagementStation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_management_station oci_os_management_hub_management_station} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciOsManagementHubManagementStation(Constructs.Construct scope, string id, oci.DataOciOsManagementHubManagementStation.IDataOciOsManagementHubManagementStationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciOsManagementHubManagementStation.IDataOciOsManagementHubManagementStationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagementStation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubManagementStation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciOsManagementHubManagementStation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciOsManagementHubManagementStation to import.</param>
        /// <param name="importFromId">The id of the existing DataOciOsManagementHubManagementStation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciOsManagementHubManagementStation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciOsManagementHubManagementStation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/os_management_hub_management_station#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciOsManagementHubManagementStation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciOsManagementHubManagementStation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStation))!;

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

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "health", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationHealthList\"}")]
        public virtual oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationHealthList Health
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationHealthList>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isAutoConfigEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoConfigEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "mirror", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationMirrorList\"}")]
        public virtual oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationMirrorList Mirror
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationMirrorList>()!;
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

        [JsiiProperty(name: "mirrorSyncStatus", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationMirrorSyncStatusList\"}")]
        public virtual oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationMirrorSyncStatusList MirrorSyncStatus
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationMirrorSyncStatusList>()!;
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

        [JsiiProperty(name: "peerManagementStations", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationPeerManagementStationsList\"}")]
        public virtual oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationPeerManagementStationsList PeerManagementStations
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationPeerManagementStationsList>()!;
        }

        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proxy", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationProxyList\"}")]
        public virtual oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationProxyList Proxy
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubManagementStation.DataOciOsManagementHubManagementStationProxyList>()!;
        }

        [JsiiProperty(name: "refreshTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefreshTrigger
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "totalMirrors", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalMirrors
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "managementStationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagementStationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "managementStationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagementStationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
