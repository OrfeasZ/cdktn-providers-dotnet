using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePagesProject
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/pages_project cloudflare_pages_project}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProject), fullyQualifiedName: "cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectConfig\"}}]")]
    public class DataCloudflarePagesProject : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/pages_project cloudflare_pages_project} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflarePagesProject(Constructs.Construct scope, string id, cloudflare.DataCloudflarePagesProject.IDataCloudflarePagesProjectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflarePagesProject.IDataCloudflarePagesProjectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflarePagesProject(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflarePagesProject resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflarePagesProject to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflarePagesProject that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflarePagesProject to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflarePagesProject to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/pages_project#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflarePagesProject that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflarePagesProject to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProject), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProject))!;

        [JsiiProperty(name: "buildConfig", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectBuildConfigOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectBuildConfigOutputReference BuildConfig
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectBuildConfigOutputReference>()!;
        }

        [JsiiProperty(name: "canonicalDeployment", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectCanonicalDeploymentOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectCanonicalDeploymentOutputReference CanonicalDeployment
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectCanonicalDeploymentOutputReference>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentConfigs", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsOutputReference DeploymentConfigs
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectDeploymentConfigsOutputReference>()!;
        }

        [JsiiProperty(name: "domains", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Domains
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "framework", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Framework
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "frameworkVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FrameworkVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestDeployment", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectLatestDeploymentOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectLatestDeploymentOutputReference LatestDeployment
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectLatestDeploymentOutputReference>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "previewScriptName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreviewScriptName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productionBranch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductionBranch
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productionScriptName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductionScriptName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"cloudflare.dataCloudflarePagesProject.DataCloudflarePagesProjectSourceOutputReference\"}")]
        public virtual cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectSourceOutputReference Source
        {
            get => GetInstanceProperty<cloudflare.DataCloudflarePagesProject.DataCloudflarePagesProjectSourceOutputReference>()!;
        }

        [JsiiProperty(name: "subdomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subdomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "usesFunctions", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UsesFunctions
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "projectNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProjectNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "projectName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
