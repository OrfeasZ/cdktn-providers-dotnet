using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PagesProject
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project cloudflare_pages_project}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.PagesProject.PagesProject), fullyQualifiedName: "cloudflare.pagesProject.PagesProject", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectConfig\"}}]")]
    public class PagesProject : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project cloudflare_pages_project} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public PagesProject(Constructs.Construct scope, string id, cloudflare.PagesProject.IPagesProjectConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.PagesProject.IPagesProjectConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProject(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PagesProject(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a PagesProject resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the PagesProject to import.</param>
        /// <param name="importFromId">The id of the existing PagesProject that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the PagesProject to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the PagesProject to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/pages_project#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing PagesProject that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the PagesProject to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.PagesProject.PagesProject), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBuildConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectBuildConfig\"}}]")]
        public virtual void PutBuildConfig(cloudflare.PagesProject.IPagesProjectBuildConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PagesProject.IPagesProjectBuildConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeploymentConfigs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigs\"}}]")]
        public virtual void PutDeploymentConfigs(cloudflare.PagesProject.IPagesProjectDeploymentConfigs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PagesProject.IPagesProjectDeploymentConfigs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"cloudflare.pagesProject.PagesProjectSource\"}}]")]
        public virtual void PutSource(cloudflare.PagesProject.IPagesProjectSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(cloudflare.PagesProject.IPagesProjectSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBuildConfig")]
        public virtual void ResetBuildConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeploymentConfigs")]
        public virtual void ResetDeploymentConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
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
        = GetStaticProperty<string>(typeof(cloudflare.PagesProject.PagesProject))!;

        [JsiiProperty(name: "buildConfig", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectBuildConfigOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectBuildConfigOutputReference BuildConfig
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectBuildConfigOutputReference>()!;
        }

        [JsiiProperty(name: "canonicalDeployment", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectCanonicalDeploymentOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectCanonicalDeploymentOutputReference CanonicalDeployment
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectCanonicalDeploymentOutputReference>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentConfigs", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigsOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectDeploymentConfigsOutputReference DeploymentConfigs
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectDeploymentConfigsOutputReference>()!;
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

        [JsiiProperty(name: "latestDeployment", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectLatestDeploymentOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectLatestDeploymentOutputReference LatestDeployment
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectLatestDeploymentOutputReference>()!;
        }

        [JsiiProperty(name: "previewScriptName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreviewScriptName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "productionScriptName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductionScriptName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"cloudflare.pagesProject.PagesProjectSourceOutputReference\"}")]
        public virtual cloudflare.PagesProject.PagesProjectSourceOutputReference Source
        {
            get => GetInstanceProperty<cloudflare.PagesProject.PagesProjectSourceOutputReference>()!;
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
        [JsiiProperty(name: "buildConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectBuildConfig\"}]}}", isOptional: true)]
        public virtual object? BuildConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentConfigsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectDeploymentConfigs\"}]}}", isOptional: true)]
        public virtual object? DeploymentConfigsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productionBranchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductionBranchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"cloudflare.pagesProject.PagesProjectSource\"}]}}", isOptional: true)]
        public virtual object? SourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "productionBranch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProductionBranch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
