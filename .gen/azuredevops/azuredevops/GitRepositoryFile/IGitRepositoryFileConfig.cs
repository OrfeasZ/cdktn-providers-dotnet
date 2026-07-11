using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuredevops.GitRepositoryFile
{
    [JsiiInterface(nativeType: typeof(IGitRepositoryFileConfig), fullyQualifiedName: "azuredevops.gitRepositoryFile.GitRepositoryFileConfig")]
    public interface IGitRepositoryFileConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The file's content.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#content GitRepositoryFile#content}
        /// </remarks>
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        string Content
        {
            get;
        }

        /// <summary>The file path to manage.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#file GitRepositoryFile#file}
        /// </remarks>
        [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
        string File
        {
            get;
        }

        /// <summary>The repository ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#repository_id GitRepositoryFile#repository_id}
        /// </remarks>
        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        string RepositoryId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#author_email GitRepositoryFile#author_email}.</summary>
        [JsiiProperty(name: "authorEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorEmail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#author_name GitRepositoryFile#author_name}.</summary>
        [JsiiProperty(name: "authorName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The branch name, defaults to "refs/heads/master".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#branch GitRepositoryFile#branch}
        /// </remarks>
        [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Branch
        {
            get
            {
                return null;
            }
        }

        /// <summary>The commit message when creating or updating the file.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#commit_message GitRepositoryFile#commit_message}
        /// </remarks>
        [JsiiProperty(name: "commitMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommitMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#committer_email GitRepositoryFile#committer_email}.</summary>
        [JsiiProperty(name: "committerEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommitterEmail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#committer_name GitRepositoryFile#committer_name}.</summary>
        [JsiiProperty(name: "committerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CommitterName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#id GitRepositoryFile#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Enable overwriting existing files, defaults to "false".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#overwrite_on_create GitRepositoryFile#overwrite_on_create}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "overwriteOnCreate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OverwriteOnCreate
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#timeouts GitRepositoryFile#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.gitRepositoryFile.GitRepositoryFileTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuredevops.GitRepositoryFile.IGitRepositoryFileTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGitRepositoryFileConfig), fullyQualifiedName: "azuredevops.gitRepositoryFile.GitRepositoryFileConfig")]
        internal sealed class _Proxy : DeputyBase, azuredevops.GitRepositoryFile.IGitRepositoryFileConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The file's content.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#content GitRepositoryFile#content}
            /// </remarks>
            [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
            public string Content
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The file path to manage.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#file GitRepositoryFile#file}
            /// </remarks>
            [JsiiProperty(name: "file", typeJson: "{\"primitive\":\"string\"}")]
            public string File
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The repository ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#repository_id GitRepositoryFile#repository_id}
            /// </remarks>
            [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
            public string RepositoryId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#author_email GitRepositoryFile#author_email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorEmail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#author_name GitRepositoryFile#author_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The branch name, defaults to "refs/heads/master".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#branch GitRepositoryFile#branch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "branch", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Branch
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The commit message when creating or updating the file.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#commit_message GitRepositoryFile#commit_message}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "commitMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommitMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#committer_email GitRepositoryFile#committer_email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "committerEmail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommitterEmail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#committer_name GitRepositoryFile#committer_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "committerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CommitterName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#id GitRepositoryFile#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Enable overwriting existing files, defaults to "false".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#overwrite_on_create GitRepositoryFile#overwrite_on_create}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overwriteOnCreate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? OverwriteOnCreate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/microsoft/azuredevops/1.15.1/docs/resources/git_repository_file#timeouts GitRepositoryFile#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuredevops.gitRepositoryFile.GitRepositoryFileTimeouts\"}", isOptional: true)]
            public azuredevops.GitRepositoryFile.IGitRepositoryFileTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuredevops.GitRepositoryFile.IGitRepositoryFileTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
