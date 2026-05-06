using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiInterface(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetails), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetails")]
    public interface IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#custom_environment_variables DatascienceNotebookSession#custom_environment_variables}.</summary>
        [JsiiProperty(name: "customEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? CustomEnvironmentVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>notebook_session_git_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_git_config_details DatascienceNotebookSession#notebook_session_git_config_details}
        /// </remarks>
        [JsiiProperty(name: "notebookSessionGitConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails? NotebookSessionGitConfigDetails
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetails), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#custom_environment_variables DatascienceNotebookSession#custom_environment_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customEnvironmentVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? CustomEnvironmentVariables
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>notebook_session_git_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_git_config_details DatascienceNotebookSession#notebook_session_git_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notebookSessionGitConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails\"}", isOptional: true)]
            public oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails? NotebookSessionGitConfigDetails
            {
                get => GetInstanceProperty<oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetailsNotebookSessionGitConfigDetails?>();
            }
        }
    }
}
