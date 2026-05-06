using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_operation oci_database_management_managed_database_optimizer_statistics_collection_operation}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation), fullyQualifiedName: "oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationConfig\"}}]")]
    public class DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_operation oci_database_management_managed_database_optimizer_statistics_collection_operation} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.IDataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_management_managed_database_optimizer_statistics_collection_operation#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation))!;

        [JsiiProperty(name: "completedCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompletedCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationDatabaseList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationDatabaseList Database
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationDatabaseList>()!;
        }

        [JsiiProperty(name: "durationInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DurationInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "failedCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FailedCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inProgressCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InProgressCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "jobName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "operationName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Target
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tasks", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationTasksList\"}")]
        public virtual oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationTasksList Tasks
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperation.DataOciDatabaseManagementManagedDatabaseOptimizerStatisticsCollectionOperationTasksList>()!;
        }

        [JsiiProperty(name: "timedOutCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TimedOutCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalObjectsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalObjectsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedDatabaseIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedDatabaseIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optimizerStatisticsCollectionOperationIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? OptimizerStatisticsCollectionOperationIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedDatabaseId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedDatabaseId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "optimizerStatisticsCollectionOperationId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OptimizerStatisticsCollectionOperationId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
