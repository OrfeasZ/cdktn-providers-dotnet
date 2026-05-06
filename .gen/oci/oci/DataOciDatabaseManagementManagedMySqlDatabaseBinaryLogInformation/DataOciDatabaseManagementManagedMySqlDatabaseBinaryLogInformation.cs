using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_binary_log_information oci_database_management_managed_my_sql_database_binary_log_information}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformationConfig\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_binary_log_information oci_database_management_managed_my_sql_database_binary_log_information} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation.IDataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation.IDataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_binary_log_information#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation.DataOciDatabaseManagementManagedMySqlDatabaseBinaryLogInformation))!;

        [JsiiProperty(name: "binaryLogCompression", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BinaryLogCompression
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "binaryLogCompressionPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BinaryLogCompressionPercent
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "binaryLogName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BinaryLogName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "binaryLogPosition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BinaryLogPosition
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
