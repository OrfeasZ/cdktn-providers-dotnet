using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiInterface(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails")]
    public interface IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails
    {
        /// <summary>notebook_session_git_repo_config_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_git_repo_config_collection DatascienceNotebookSession#notebook_session_git_repo_config_collection}
        /// </remarks>
        [JsiiProperty(name: "notebookSessionGitRepoConfigCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NotebookSessionGitRepoConfigCollection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>notebook_session_git_repo_config_collection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_git_repo_config_collection DatascienceNotebookSession#notebook_session_git_repo_config_collection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notebookSessionGitRepoConfigCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NotebookSessionGitRepoConfigCollection
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
