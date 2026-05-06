using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDevopsDeployment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_deployment oci_devops_deployment}.</summary>
    [JsiiClass(nativeType: typeof(oci.DataOciDevopsDeployment.DataOciDevopsDeployment), fullyQualifiedName: "oci.dataOciDevopsDeployment.DataOciDevopsDeployment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.dataOciDevopsDeployment.DataOciDevopsDeploymentConfig\"}}]")]
    public class DataOciDevopsDeployment : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_deployment oci_devops_deployment} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataOciDevopsDeployment(Constructs.Construct scope, string id, oci.DataOciDevopsDeployment.IDataOciDevopsDeploymentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.DataOciDevopsDeployment.IDataOciDevopsDeploymentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDevopsDeployment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataOciDevopsDeployment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataOciDevopsDeployment to import.</param>
        /// <param name="importFromId">The id of the existing DataOciDevopsDeployment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataOciDevopsDeployment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataOciDevopsDeployment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/devops_deployment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataOciDevopsDeployment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataOciDevopsDeployment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.DataOciDevopsDeployment.DataOciDevopsDeployment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(oci.DataOciDevopsDeployment.DataOciDevopsDeployment))!;

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "deployArtifactOverrideArguments", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployment.DataOciDevopsDeploymentDeployArtifactOverrideArgumentsList\"}")]
        public virtual oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeployArtifactOverrideArgumentsList DeployArtifactOverrideArguments
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeployArtifactOverrideArgumentsList>()!;
        }

        [JsiiProperty(name: "deploymentArguments", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployment.DataOciDevopsDeploymentDeploymentArgumentsList\"}")]
        public virtual oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeploymentArgumentsList DeploymentArguments
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeploymentArgumentsList>()!;
        }

        [JsiiProperty(name: "deploymentExecutionProgress", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployment.DataOciDevopsDeploymentDeploymentExecutionProgressList\"}")]
        public virtual oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeploymentExecutionProgressList DeploymentExecutionProgress
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeploymentExecutionProgressList>()!;
        }

        [JsiiProperty(name: "deploymentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployPipelineArtifacts", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployment.DataOciDevopsDeploymentDeployPipelineArtifactsList\"}")]
        public virtual oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeployPipelineArtifactsList DeployPipelineArtifacts
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeployPipelineArtifactsList>()!;
        }

        [JsiiProperty(name: "deployPipelineEnvironments", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployment.DataOciDevopsDeploymentDeployPipelineEnvironmentsList\"}")]
        public virtual oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeployPipelineEnvironmentsList DeployPipelineEnvironments
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeployPipelineEnvironmentsList>()!;
        }

        [JsiiProperty(name: "deployPipelineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployPipelineId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployStageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeployStageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployStageOverrideArguments", typeJson: "{\"fqn\":\"oci.dataOciDevopsDeployment.DataOciDevopsDeploymentDeployStageOverrideArgumentsList\"}")]
        public virtual oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeployStageOverrideArgumentsList DeployStageOverrideArguments
        {
            get => GetInstanceProperty<oci.DataOciDevopsDeployment.DataOciDevopsDeploymentDeployStageOverrideArgumentsList>()!;
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

        [JsiiProperty(name: "previousDeploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreviousDeploymentId
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

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "triggerNewDevopsDeployment", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable TriggerNewDevopsDeployment
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
