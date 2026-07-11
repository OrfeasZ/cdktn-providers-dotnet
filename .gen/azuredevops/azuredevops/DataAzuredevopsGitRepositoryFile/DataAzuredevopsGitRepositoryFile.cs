using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.DataAzuredevopsGitRepositoryFile
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/git_repository_file azuredevops_git_repository_file}.</summary>
    [JsiiClass(nativeType: typeof(azuredevops.DataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFile), fullyQualifiedName: "azuredevops.dataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFile", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFileConfig\"}}]")]
    public class DataAzuredevopsGitRepositoryFile : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/git_repository_file azuredevops_git_repository_file} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzuredevopsGitRepositoryFile(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsGitRepositoryFile.IDataAzuredevopsGitRepositoryFileConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azuredevops.DataAzuredevopsGitRepositoryFile.IDataAzuredevopsGitRepositoryFileConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsGitRepositoryFile(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzuredevopsGitRepositoryFile(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAzuredevopsGitRepositoryFile resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzuredevopsGitRepositoryFile to import.</param>
        /// <param name="importFromId">The id of the existing DataAzuredevopsGitRepositoryFile that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzuredevopsGitRepositoryFile to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzuredevopsGitRepositoryFile to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/data-sources/git_repository_file#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzuredevopsGitRepositoryFile that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzuredevopsGitRepositoryFile to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(azuredevops.DataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFile), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azuredevops.dataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFileTimeouts\"}}]")]
        public virtual void PutTimeouts(azuredevops.DataAzuredevopsGitRepositoryFile.IDataAzuredevopsGitRepositoryFileTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azuredevops.DataAzuredevopsGitRepositoryFile.IDataAzuredevopsGitRepositoryFileTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBranch")]
        public virtual void ResetBranch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTag")]
        public virtual void ResetTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(azuredevops.DataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFile))!;

        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Content
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastCommitMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastCommitMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.dataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFileTimeoutsOutputReference\"}")]
        public virtual azuredevops.DataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFileTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azuredevops.DataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFileTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "branchInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BranchInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TagInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="azuredevops.DataAzuredevopsGitRepositoryFile.IDataAzuredevopsGitRepositoryFileTimeouts" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"azuredevops.dataAzuredevopsGitRepositoryFile.DataAzuredevopsGitRepositoryFileTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Branch
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string File
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Tag
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
