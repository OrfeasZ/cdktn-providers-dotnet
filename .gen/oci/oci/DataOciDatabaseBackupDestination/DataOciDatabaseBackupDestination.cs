using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseBackupDestination
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_backup_destination oci_database_backup_destination}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestination), fullyQualifiedName: "oci.dataOciDatabaseBackupDestination.DataOciDatabaseBackupDestination", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationConfig\"}}]")]
    public class DataOciDatabaseBackupDestination : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_backup_destination oci_database_backup_destination} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseBackupDestination(Constructs.Construct scope, string id, oci.DataOciDatabaseBackupDestination.IDataOciDatabaseBackupDestinationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseBackupDestination.IDataOciDatabaseBackupDestinationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseBackupDestination(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseBackupDestination(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseBackupDestination resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseBackupDestination to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseBackupDestination that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseBackupDestination to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseBackupDestination to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_backup_destination#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseBackupDestination that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseBackupDestination to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestination), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestination))!;

        [JsiiProperty(name: "associatedDatabases", typeJson: "{\"fqn\":\"oci.dataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationAssociatedDatabasesList\"}")]
        public virtual oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationAssociatedDatabasesList AssociatedDatabases
        {
            get => GetInstanceProperty<oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationAssociatedDatabasesList>()!;
        }

        [JsiiProperty(name: "associatedLongTermBackupCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AssociatedLongTermBackupCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "associatedLongTermBackups", typeJson: "{\"fqn\":\"oci.dataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationAssociatedLongTermBackupsList\"}")]
        public virtual oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationAssociatedLongTermBackupsList AssociatedLongTermBackups
        {
            get => GetInstanceProperty<oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationAssociatedLongTermBackupsList>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionString
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localMountPointPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalMountPointPath
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mountTypeDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationMountTypeDetailsList\"}")]
        public virtual oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationMountTypeDetailsList MountTypeDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseBackupDestination.DataOciDatabaseBackupDestinationMountTypeDetailsList>()!;
        }

        [JsiiProperty(name: "nfsMountType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NfsMountType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nfsServer", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NfsServer
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "nfsServerExport", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NfsServerExport
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

        [JsiiProperty(name: "timeAtWhichStorageDetailsAreUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAtWhichStorageDetailsAreUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "utilizedStorageSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UtilizedStorageSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "vpcUsers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VpcUsers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupDestinationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backupDestinationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupDestinationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
