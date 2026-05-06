using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_query_detail oci_database_management_managed_my_sql_database_query_detail}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailConfig\"}}]")]
    public class DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_query_detail oci_database_management_managed_my_sql_database_query_detail} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.IDataOciDatabaseManagementManagedMySqlDatabaseQueryDetailConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.IDataOciDatabaseManagementManagedMySqlDatabaseQueryDetailConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_my_sql_database_query_detail#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail))!;

        [JsiiProperty(name: "queryExplainPlan", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQueryExplainPlanList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQueryExplainPlanList QueryExplainPlan
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQueryExplainPlanList>()!;
        }

        [JsiiProperty(name: "queryMessages", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQueryMessagesList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQueryMessagesList QueryMessages
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQueryMessagesList>()!;
        }

        [JsiiProperty(name: "querySampleDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQuerySampleDetailsList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQuerySampleDetailsList QuerySampleDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetail.DataOciDatabaseManagementManagedMySqlDatabaseQueryDetailQuerySampleDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "digestInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DigestInput
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
        [JsiiProperty(name: "managedMySqlDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedMySqlDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "digest", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Digest
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

        [JsiiProperty(name: "managedMySqlDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedMySqlDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
