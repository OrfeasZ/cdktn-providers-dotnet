using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiInterface(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection")]
    public interface IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#url DatascienceNotebookSession#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetailsNotebookSessionGitRepoConfigCollection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#url DatascienceNotebookSession#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
