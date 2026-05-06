using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiByValue(fqn: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetails")]
    public class DatascienceNotebookSessionNotebookSessionRuntimeConfigDetails : oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#custom_environment_variables DatascienceNotebookSession#custom_environment_variables}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? CustomEnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>notebook_session_git_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_git_config_details DatascienceNotebookSession#notebook_session_git_config_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notebookSessionGitConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails\"}", isOptional: true)]
        public oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails? NotebookSessionGitConfigDetails
        {
            get;
            set;
        }
    }
}
