using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMaintenanceRunHistory
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_maintenance_run_history oci_database_maintenance_run_history}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistory), fullyQualifiedName: "oci.dataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistory", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryConfig\"}}]")]
    public class DataOciDatabaseMaintenanceRunHistory : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_maintenance_run_history oci_database_maintenance_run_history} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseMaintenanceRunHistory(Constructs.Construct scope, string id, oci.DataOciDatabaseMaintenanceRunHistory.IDataOciDatabaseMaintenanceRunHistoryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseMaintenanceRunHistory.IDataOciDatabaseMaintenanceRunHistoryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMaintenanceRunHistory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMaintenanceRunHistory(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseMaintenanceRunHistory resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseMaintenanceRunHistory to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseMaintenanceRunHistory that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseMaintenanceRunHistory to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseMaintenanceRunHistory to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_maintenance_run_history#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseMaintenanceRunHistory that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseMaintenanceRunHistory to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistory), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistory))!;

        [JsiiProperty(name: "currentExecutionWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentExecutionWindow
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dbServersHistoryDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryDbServersHistoryDetailsList\"}")]
        public virtual oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryDbServersHistoryDetailsList DbServersHistoryDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryDbServersHistoryDetailsList>()!;
        }

        [JsiiProperty(name: "granularMaintenanceHistory", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryGranularMaintenanceHistoryList\"}")]
        public virtual oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryGranularMaintenanceHistoryList GranularMaintenanceHistory
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryGranularMaintenanceHistoryList>()!;
        }

        [JsiiProperty(name: "maintenanceRunDetails", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryMaintenanceRunDetailsList\"}")]
        public virtual oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryMaintenanceRunDetailsList MaintenanceRunDetails
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMaintenanceRunHistory.DataOciDatabaseMaintenanceRunHistoryMaintenanceRunDetailsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceRunHistoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceRunHistoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maintenanceRunHistoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceRunHistoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
