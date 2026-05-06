using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiByValue(fqn: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails")]
    public class DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails : oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails
    {
        private object? _notebookSessionGitRepoConfigCollection;

        /// <summary>notebook_session_git_repo_config_collection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_git_repo_config_collection DatascienceNotebookSession#notebook_session_git_repo_config_collection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notebookSessionGitRepoConfigCollection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NotebookSessionGitRepoConfigCollection
        {
            get => _notebookSessionGitRepoConfigCollection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _notebookSessionGitRepoConfigCollection = value;
            }
        }
    }
}
