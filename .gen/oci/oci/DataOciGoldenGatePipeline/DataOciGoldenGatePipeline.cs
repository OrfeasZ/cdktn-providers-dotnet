using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciGoldenGatePipeline
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/golden_gate_pipeline oci_golden_gate_pipeline}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipeline), fullyQualifiedName: "oci.dataOciGoldenGatePipeline.DataOciGoldenGatePipeline", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciGoldenGatePipeline.DataOciGoldenGatePipelineConfig\"}}]")]
    public class DataOciGoldenGatePipeline : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/golden_gate_pipeline oci_golden_gate_pipeline} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciGoldenGatePipeline(Constructs.Construct scope, string id, oci.DataOciGoldenGatePipeline.IDataOciGoldenGatePipelineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciGoldenGatePipeline.IDataOciGoldenGatePipelineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGatePipeline(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciGoldenGatePipeline(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciGoldenGatePipeline resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciGoldenGatePipeline to import.</param>
        /// <param name="importFromId">The id of the existing DataOciGoldenGatePipeline that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciGoldenGatePipeline to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciGoldenGatePipeline to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/golden_gate_pipeline#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciGoldenGatePipeline that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciGoldenGatePipeline to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipeline), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipeline))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cpuCoreCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuCoreCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
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

        [JsiiProperty(name: "isAutoScalingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsAutoScalingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "licenseModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LicenseModel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleSubState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleSubState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "locks", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipeline.DataOciGoldenGatePipelineLocksList\"}")]
        public virtual oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineLocksList Locks
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineLocksList>()!;
        }

        [JsiiProperty(name: "mappingRules", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipeline.DataOciGoldenGatePipelineMappingRulesList\"}")]
        public virtual oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineMappingRulesList MappingRules
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineMappingRulesList>()!;
        }

        [JsiiProperty(name: "pipelineDiagnosticData", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipeline.DataOciGoldenGatePipelinePipelineDiagnosticDataList\"}")]
        public virtual oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelinePipelineDiagnosticDataList PipelineDiagnosticData
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelinePipelineDiagnosticDataList>()!;
        }

        [JsiiProperty(name: "processOptions", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipeline.DataOciGoldenGatePipelineProcessOptionsList\"}")]
        public virtual oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineProcessOptionsList ProcessOptions
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineProcessOptionsList>()!;
        }

        [JsiiProperty(name: "recipeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecipeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceConnectionDetails", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipeline.DataOciGoldenGatePipelineSourceConnectionDetailsList\"}")]
        public virtual oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineSourceConnectionDetailsList SourceConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineSourceConnectionDetailsList>()!;
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

        [JsiiProperty(name: "targetConnectionDetails", typeJson: "{\"fqn\":\"oci.dataOciGoldenGatePipeline.DataOciGoldenGatePipelineTargetConnectionDetailsList\"}")]
        public virtual oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineTargetConnectionDetailsList TargetConnectionDetails
        {
            get => GetInstanceProperty<oci.DataOciGoldenGatePipeline.DataOciGoldenGatePipelineTargetConnectionDetailsList>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeLastRecorded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeLastRecorded
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "pipelineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PipelineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PipelineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
