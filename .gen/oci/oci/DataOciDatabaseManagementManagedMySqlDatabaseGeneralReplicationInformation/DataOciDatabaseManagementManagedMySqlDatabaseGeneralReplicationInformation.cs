using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_general_replication_information oci_database_management_managed_my_sql_database_general_replication_information}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformationConfig\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_general_replication_information oci_database_management_managed_my_sql_database_general_replication_information} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation.IDataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation.IDataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_general_replication_information#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation.DataOciDatabaseManagementManagedMySqlDatabaseGeneralReplicationInformation))!;

        [JsiiProperty(name: "applyStatusSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyStatusSummary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "binaryLogFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BinaryLogFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "binaryLogging", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BinaryLogging
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executedGtidSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutedGtidSet
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fetchStatusSummary", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FetchStatusSummary
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gtidMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GtidMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "highAvailabilityMemberState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HighAvailabilityMemberState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inboundReplicationsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InboundReplicationsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isHighAvailabilityEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsHighAvailabilityEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "outboundReplicationsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OutboundReplicationsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadOnly
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secondsBehindSourceMax", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecondsBehindSourceMax
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serverUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedMySqlDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedMySqlDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedMySqlDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedMySqlDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
