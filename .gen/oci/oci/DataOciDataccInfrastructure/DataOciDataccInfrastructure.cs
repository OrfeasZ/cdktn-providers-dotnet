using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDataccInfrastructure
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/data-sources/datacc_infrastructure oci_datacc_infrastructure}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDataccInfrastructure.DataOciDataccInfrastructure), fullyQualifiedName: "oci.dataOciDataccInfrastructure.DataOciDataccInfrastructure", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDataccInfrastructure.DataOciDataccInfrastructureConfig\"}}]")]
    public class DataOciDataccInfrastructure : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/data-sources/datacc_infrastructure oci_datacc_infrastructure} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDataccInfrastructure(Constructs.Construct scope, string id, oci.DataOciDataccInfrastructure.IDataOciDataccInfrastructureConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDataccInfrastructure.IDataOciDataccInfrastructureConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataccInfrastructure(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDataccInfrastructure(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDataccInfrastructure resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDataccInfrastructure to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDataccInfrastructure that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDataccInfrastructure to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDataccInfrastructure to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/data-sources/datacc_infrastructure#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDataccInfrastructure that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDataccInfrastructure to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDataccInfrastructure.DataOciDataccInfrastructure), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDataccInfrastructure.DataOciDataccInfrastructure))!;

        [JsiiProperty(name: "acfsFileSystemStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcfsFileSystemStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "acfsFileSystemUsedStorageInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AcfsFileSystemUsedStorageInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "adminNetworkcidr", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminNetworkcidr
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlPlaneServer1", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer1
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cloudControlPlaneServer2", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudControlPlaneServer2
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "computeCapacity", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructure.DataOciDataccInfrastructureComputeCapacityList\"}")]
        public virtual oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureComputeCapacityList ComputeCapacity
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureComputeCapacityList>()!;
        }

        [JsiiProperty(name: "contacts", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructure.DataOciDataccInfrastructureContactsList\"}")]
        public virtual oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureContactsList Contacts
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureContactsList>()!;
        }

        [JsiiProperty(name: "corporateProxy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CorporateProxy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpsNetworkBondingInterface", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpsNetworkBondingInterface
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpsNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CpsNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataDiskPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataDiskPercentage
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "dnsServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "gateway", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Gateway
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleStateDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleStateDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructure.DataOciDataccInfrastructureMaintenanceWindowList\"}")]
        public virtual oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "netmask", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Netmask
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkAdapterConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAdapterConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ntpServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NtpServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "rackSerialNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RackSerialNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recoDiskPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RecoDiskPercentage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "scaleStorageTrigger", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ScaleStorageTrigger
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "servers", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructure.DataOciDataccInfrastructureServersList\"}")]
        public virtual oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureServersList Servers
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureServersList>()!;
        }

        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Shape
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ssdConfigurationRequested", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SsdConfigurationRequested
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageCapacity", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructure.DataOciDataccInfrastructureStorageCapacityList\"}")]
        public virtual oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureStorageCapacityList StorageCapacity
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureStorageCapacityList>()!;
        }

        [JsiiProperty(name: "subscriptionPlanNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionPlanNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SystemModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemStorageCapacity", typeJson: "{\"fqn\":\"oci.dataOciDataccInfrastructure.DataOciDataccInfrastructureSystemStorageCapacityList\"}")]
        public virtual oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureSystemStorageCapacityList SystemStorageCapacity
        {
            get => GetInstanceProperty<oci.DataOciDataccInfrastructure.DataOciDataccInfrastructureSystemStorageCapacityList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeActivated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeActivated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastStateUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastStateUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeValidated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeValidated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VlanId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "infrastructureIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InfrastructureIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "infrastructureId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InfrastructureId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
