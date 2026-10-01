using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanAgentPlatformCustomModel
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_custom_model digitalocean_agent_platform_custom_model}.</summary>
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModel), fullyQualifiedName: "digitalocean.dataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModel", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModelConfig\"}}]")]
    public class DataDigitaloceanAgentPlatformCustomModel : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_custom_model digitalocean_agent_platform_custom_model} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataDigitaloceanAgentPlatformCustomModel(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanAgentPlatformCustomModel.IDataDigitaloceanAgentPlatformCustomModelConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, digitalocean.DataDigitaloceanAgentPlatformCustomModel.IDataDigitaloceanAgentPlatformCustomModelConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformCustomModel(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanAgentPlatformCustomModel(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataDigitaloceanAgentPlatformCustomModel resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataDigitaloceanAgentPlatformCustomModel to import.</param>
        /// <param name="importFromId">The id of the existing DataDigitaloceanAgentPlatformCustomModel that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataDigitaloceanAgentPlatformCustomModel to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataDigitaloceanAgentPlatformCustomModel to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.103.0/docs/data-sources/agent_platform_custom_model#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataDigitaloceanAgentPlatformCustomModel that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataDigitaloceanAgentPlatformCustomModel to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(digitalocean.DataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModel), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(digitalocean.DataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModel))!;

        [JsiiProperty(name: "activeDeployments", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModelActiveDeploymentsList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModelActiveDeploymentsList ActiveDeployments
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModelActiveDeploymentsList>()!;
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contextLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ContextLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "costEstimatePerMonth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CostEstimatePerMonth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FileCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inputModalities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] InputModalities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "license", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string License
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outputModalities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OutputModalities
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Parameters
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceRef", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModelSourceRefList\"}")]
        public virtual digitalocean.DataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModelSourceRefList SourceRef
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanAgentPlatformCustomModel.DataDigitaloceanAgentPlatformCustomModelSourceRefList>()!;
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "storageRegion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageRegion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tags
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "teamId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TeamId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalSizeBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TotalSizeBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
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
        [JsiiProperty(name: "uuidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UuidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uuid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
