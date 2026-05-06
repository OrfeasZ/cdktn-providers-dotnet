using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciMysqlMysqlDbSystem
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/mysql_mysql_db_system oci_mysql_mysql_db_system}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystem), fullyQualifiedName: "oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystem", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemConfig\"}}]")]
    public class DataOciMysqlMysqlDbSystem : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/mysql_mysql_db_system oci_mysql_mysql_db_system} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciMysqlMysqlDbSystem(Constructs.Construct scope, string id, oci.DataOciMysqlMysqlDbSystem.IDataOciMysqlMysqlDbSystemConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciMysqlMysqlDbSystem.IDataOciMysqlMysqlDbSystemConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlDbSystem(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciMysqlMysqlDbSystem(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciMysqlMysqlDbSystem resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciMysqlMysqlDbSystem to import.</param>
        /// <param name="importFromId">The id of the existing DataOciMysqlMysqlDbSystem that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciMysqlMysqlDbSystem to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciMysqlMysqlDbSystem to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/mysql_mysql_db_system#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciMysqlMysqlDbSystem that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciMysqlMysqlDbSystem to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystem), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystem))!;

        [JsiiProperty(name: "accessMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "adminUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilityDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyList BackupPolicy
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemBackupPolicyList>()!;
        }

        [JsiiProperty(name: "channels", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemChannelsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemChannelsList Channels
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemChannelsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "crashRecovery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrashRecovery
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentPlacement", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemCurrentPlacementList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemCurrentPlacementList CurrentPlacement
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemCurrentPlacementList>()!;
        }

        [JsiiProperty(name: "customerContacts", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemCustomerContactsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemCustomerContactsList CustomerContacts
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemCustomerContactsList>()!;
        }

        [JsiiProperty(name: "databaseManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseManagement
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataStorage", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemDataStorageList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemDataStorageList DataStorage
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemDataStorageList>()!;
        }

        [JsiiProperty(name: "dataStorageSizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataStorageSizeInGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deletionPolicy", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemDeletionPolicyList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemDeletionPolicyList DeletionPolicy
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemDeletionPolicyList>()!;
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

        [JsiiProperty(name: "encryptData", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemEncryptDataList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemEncryptDataList EncryptData
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemEncryptDataList>()!;
        }

        [JsiiProperty(name: "endpoints", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemEndpointsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemEndpointsList Endpoints
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemEndpointsList>()!;
        }

        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "heatWaveCluster", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemHeatWaveClusterList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemHeatWaveClusterList HeatWaveCluster
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemHeatWaveClusterList>()!;
        }

        [JsiiProperty(name: "hostnameLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostnameLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isHeatWaveClusterAttached", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHeatWaveClusterAttached
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isHighlyAvailable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHighlyAvailable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenance", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemMaintenanceList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemMaintenanceList Maintenance
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemMaintenanceList>()!;
        }

        [JsiiProperty(name: "mysqlVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MysqlVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "pointInTimeRecoveryDetails", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemPointInTimeRecoveryDetailsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemPointInTimeRecoveryDetailsList PointInTimeRecoveryDetails
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemPointInTimeRecoveryDetailsList>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "portX", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PortX
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readEndpoint", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemReadEndpointList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemReadEndpointList ReadEndpoint
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemReadEndpointList>()!;
        }

        [JsiiProperty(name: "rest", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemRestList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemRestList Rest
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemRestList>()!;
        }

        [JsiiProperty(name: "secureConnections", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemSecureConnectionsList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemSecureConnectionsList SecureConnections
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemSecureConnectionsList>()!;
        }

        [JsiiProperty(name: "securityAttributes", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SecurityAttributes
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "shapeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShapeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "shutdownType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShutdownType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.dataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemSourceList\"}")]
        public virtual oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemSourceList Source
        {
            get => GetInstanceProperty<oci.DataOciMysqlMysqlDbSystem.DataOciMysqlMysqlDbSystemSourceList>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dbSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
