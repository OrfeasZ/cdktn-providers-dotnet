using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseMaintenanceRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_maintenance_run oci_database_maintenance_run}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseMaintenanceRun.DataOciDatabaseMaintenanceRun), fullyQualifiedName: "oci.dataOciDatabaseMaintenanceRun.DataOciDatabaseMaintenanceRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatabaseMaintenanceRun.DataOciDatabaseMaintenanceRunConfig\"}}]")]
    public class DataOciDatabaseMaintenanceRun : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_maintenance_run oci_database_maintenance_run} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatabaseMaintenanceRun(Constructs.Construct scope, string id, oci.DataOciDatabaseMaintenanceRun.IDataOciDatabaseMaintenanceRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatabaseMaintenanceRun.IDataOciDatabaseMaintenanceRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMaintenanceRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseMaintenanceRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatabaseMaintenanceRun resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatabaseMaintenanceRun to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatabaseMaintenanceRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatabaseMaintenanceRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatabaseMaintenanceRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/database_maintenance_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatabaseMaintenanceRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatabaseMaintenanceRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatabaseMaintenanceRun.DataOciDatabaseMaintenanceRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatabaseMaintenanceRun.DataOciDatabaseMaintenanceRun))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentCustomActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CurrentCustomActionTimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currentPatchingComponent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentPatchingComponent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customActionTimeoutInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CustomActionTimeoutInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "databaseSoftwareImageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseSoftwareImageId
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "estimatedComponentPatchingStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EstimatedComponentPatchingStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedPatchingTime", typeJson: "{\"fqn\":\"oci.dataOciDatabaseMaintenanceRun.DataOciDatabaseMaintenanceRunEstimatedPatchingTimeList\"}")]
        public virtual oci.DataOciDatabaseMaintenanceRun.DataOciDatabaseMaintenanceRunEstimatedPatchingTimeList EstimatedPatchingTime
        {
            get => GetInstanceProperty<oci.DataOciDatabaseMaintenanceRun.DataOciDatabaseMaintenanceRunEstimatedPatchingTimeList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isCustomActionTimeoutEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsCustomActionTimeoutEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDstFileUpdateEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDstFileUpdateEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isMaintenanceRunGranular", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsMaintenanceRunGranular
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceSubtype", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceSubtype
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchFailureCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PatchFailureCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "patchId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchingEndTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingEndTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchingStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchingStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchingStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "patchType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PatchType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerMaintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PeerMaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "peerMaintenanceRunIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PeerMaintenanceRunIds
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "targetDbServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetDbServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetStorageServerVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetStorageServerVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeEnded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeEnded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeScheduled
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalTimeTakenInMins", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalTimeTakenInMins
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceRunIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceRunIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maintenanceRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceRunId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
