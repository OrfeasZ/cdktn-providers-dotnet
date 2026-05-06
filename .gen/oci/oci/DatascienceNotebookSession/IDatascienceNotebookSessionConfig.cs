using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceNotebookSession
{
    [JsiiInterface(nativeType: typeof(IDatascienceNotebookSessionConfig), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionConfig")]
    public interface IDatascienceNotebookSessionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#compartment_id DatascienceNotebookSession#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#project_id DatascienceNotebookSession#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#defined_tags DatascienceNotebookSession#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#display_name DatascienceNotebookSession#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#freeform_tags DatascienceNotebookSession#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#id DatascienceNotebookSession#id}.</summary>
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

        /// <summary>notebook_session_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_config_details DatascienceNotebookSession#notebook_session_config_details}
        /// </remarks>
        [JsiiProperty(name: "notebookSessionConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigDetails? NotebookSessionConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>notebook_session_configuration_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_configuration_details DatascienceNotebookSession#notebook_session_configuration_details}
        /// </remarks>
        [JsiiProperty(name: "notebookSessionConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetails? NotebookSessionConfigurationDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>notebook_session_runtime_config_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_runtime_config_details DatascienceNotebookSession#notebook_session_runtime_config_details}
        /// </remarks>
        [JsiiProperty(name: "notebookSessionRuntimeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetails? NotebookSessionRuntimeConfigDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>notebook_session_storage_mount_configuration_details_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_storage_mount_configuration_details_list DatascienceNotebookSession#notebook_session_storage_mount_configuration_details_list}
        /// </remarks>
        [JsiiProperty(name: "notebookSessionStorageMountConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NotebookSessionStorageMountConfigurationDetailsList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#state DatascienceNotebookSession#state}.</summary>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#timeouts DatascienceNotebookSession#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceNotebookSession.IDatascienceNotebookSessionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceNotebookSessionConfig), fullyQualifiedName: "oci.datascienceNotebookSession.DatascienceNotebookSessionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceNotebookSession.IDatascienceNotebookSessionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#compartment_id DatascienceNotebookSession#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#project_id DatascienceNotebookSession#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#defined_tags DatascienceNotebookSession#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#display_name DatascienceNotebookSession#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#freeform_tags DatascienceNotebookSession#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#id DatascienceNotebookSession#id}.</summary>
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

            /// <summary>notebook_session_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_config_details DatascienceNotebookSession#notebook_session_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notebookSessionConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigDetails\"}", isOptional: true)]
            public oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigDetails? NotebookSessionConfigDetails
            {
                get => GetInstanceProperty<oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigDetails?>();
            }

            /// <summary>notebook_session_configuration_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_configuration_details DatascienceNotebookSession#notebook_session_configuration_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notebookSessionConfigurationDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionConfigurationDetails\"}", isOptional: true)]
            public oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetails? NotebookSessionConfigurationDetails
            {
                get => GetInstanceProperty<oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionConfigurationDetails?>();
            }

            /// <summary>notebook_session_runtime_config_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_runtime_config_details DatascienceNotebookSession#notebook_session_runtime_config_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notebookSessionRuntimeConfigDetails", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionRuntimeConfigDetails\"}", isOptional: true)]
            public oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetails? NotebookSessionRuntimeConfigDetails
            {
                get => GetInstanceProperty<oci.DatascienceNotebookSession.IDatascienceNotebookSessionNotebookSessionRuntimeConfigDetails?>();
            }

            /// <summary>notebook_session_storage_mount_configuration_details_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#notebook_session_storage_mount_configuration_details_list DatascienceNotebookSession#notebook_session_storage_mount_configuration_details_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notebookSessionStorageMountConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionNotebookSessionStorageMountConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NotebookSessionStorageMountConfigurationDetailsList
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#state DatascienceNotebookSession#state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_notebook_session#timeouts DatascienceNotebookSession#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceNotebookSession.DatascienceNotebookSessionTimeouts\"}", isOptional: true)]
            public oci.DatascienceNotebookSession.IDatascienceNotebookSessionTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatascienceNotebookSession.IDatascienceNotebookSessionTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
