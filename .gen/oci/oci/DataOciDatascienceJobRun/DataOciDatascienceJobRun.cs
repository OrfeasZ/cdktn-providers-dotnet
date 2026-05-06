using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceJobRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_job_run oci_datascience_job_run}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceJobRun.DataOciDatascienceJobRun), fullyQualifiedName: "oci.dataOciDatascienceJobRun.DataOciDatascienceJobRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunConfig\"}}]")]
    public class DataOciDatascienceJobRun : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_job_run oci_datascience_job_run} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatascienceJobRun(Constructs.Construct scope, string id, oci.DataOciDatascienceJobRun.IDataOciDatascienceJobRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatascienceJobRun.IDataOciDatascienceJobRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceJobRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceJobRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatascienceJobRun resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatascienceJobRun to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatascienceJobRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatascienceJobRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatascienceJobRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_job_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatascienceJobRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatascienceJobRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatascienceJobRun.DataOciDatascienceJobRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatascienceJobRun.DataOciDatascienceJobRun))!;

        [JsiiProperty(name: "asynchronous", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Asynchronous
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
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

        [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunJobConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobConfigurationOverrideDetailsList JobConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunJobEnvironmentConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobEnvironmentConfigurationOverrideDetailsList JobEnvironmentConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobEnvironmentConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunJobInfrastructureConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobInfrastructureConfigurationDetailsList JobInfrastructureConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobInfrastructureConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "jobInfrastructureConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsList JobInfrastructureConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunJobLogConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobLogConfigurationOverrideDetailsList JobLogConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobLogConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobNodeConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunJobNodeConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobNodeConfigurationOverrideDetailsList JobNodeConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobNodeConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "jobStorageMountConfigurationDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunJobStorageMountConfigurationDetailsListStructList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobStorageMountConfigurationDetailsListStructList JobStorageMountConfigurationDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunJobStorageMountConfigurationDetailsListStructList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunLogDetailsList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunLogDetailsList LogDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunLogDetailsList>()!;
        }

        [JsiiProperty(name: "nodeGroupDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatascienceJobRun.DataOciDatascienceJobRunNodeGroupDetailsListStructList\"}")]
        public virtual oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunNodeGroupDetailsListStructList NodeGroupDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatascienceJobRun.DataOciDatascienceJobRunNodeGroupDetailsListStructList>()!;
        }

        [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcParentRptUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeAccepted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAccepted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeFinished", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeFinished
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeStarted", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeStarted
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobRunIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? JobRunIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "jobRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JobRunId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
