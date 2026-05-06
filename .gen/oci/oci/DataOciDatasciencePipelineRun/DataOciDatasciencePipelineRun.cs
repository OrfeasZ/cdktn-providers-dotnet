using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatasciencePipelineRun
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_pipeline_run oci_datascience_pipeline_run}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRun), fullyQualifiedName: "oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRun", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunConfig\"}}]")]
    public class DataOciDatasciencePipelineRun : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_pipeline_run oci_datascience_pipeline_run} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDatasciencePipelineRun(Constructs.Construct scope, string id, oci.DataOciDatasciencePipelineRun.IDataOciDatasciencePipelineRunConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDatasciencePipelineRun.IDataOciDatasciencePipelineRunConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatasciencePipelineRun(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatasciencePipelineRun(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDatasciencePipelineRun resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDatasciencePipelineRun to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDatasciencePipelineRun that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDatasciencePipelineRun to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDatasciencePipelineRun to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/datascience_pipeline_run#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDatasciencePipelineRun that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDatasciencePipelineRun to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRun), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRun))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configurationDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunConfigurationDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunConfigurationDetailsList ConfigurationDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunConfigurationDetailsList>()!;
        }

        [JsiiProperty(name: "configurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunConfigurationOverrideDetailsList ConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunConfigurationOverrideDetailsList>()!;
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

        [JsiiProperty(name: "deleteRelatedJobRuns", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteRelatedJobRuns
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "infrastructureConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunInfrastructureConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunInfrastructureConfigurationOverrideDetailsList InfrastructureConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunInfrastructureConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunLogConfigurationOverrideDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunLogConfigurationOverrideDetailsList LogConfigurationOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunLogConfigurationOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "logDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunLogDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunLogDetailsList LogDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunLogDetailsList>()!;
        }

        [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OpcParentRptUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "parametersOverride", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap ParametersOverride
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineId
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

        [JsiiProperty(name: "stepOverrideDetails", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsList StepOverrideDetails
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepOverrideDetailsList>()!;
        }

        [JsiiProperty(name: "stepRuns", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepRunsList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepRunsList StepRuns
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStepRunsList>()!;
        }

        [JsiiProperty(name: "storageMountConfigurationOverrideDetailsList", typeJson: "{\"fqn\":\"oci.dataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStructList\"}")]
        public virtual oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStructList StorageMountConfigurationOverrideDetailsList
        {
            get => GetInstanceProperty<oci.DataOciDatasciencePipelineRun.DataOciDatasciencePipelineRunStorageMountConfigurationOverrideDetailsListStructList>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineRunIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineRunIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "pipelineRunId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineRunId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
