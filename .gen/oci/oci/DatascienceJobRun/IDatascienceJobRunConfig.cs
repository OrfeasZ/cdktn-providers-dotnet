using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobRunConfig), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunConfig")]
    public interface IDatascienceJobRunConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#compartment_id DatascienceJobRun#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_id DatascienceJobRun#job_id}.</summary>
        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
        string JobId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#project_id DatascienceJobRun#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        string ProjectId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#asynchronous DatascienceJobRun#asynchronous}.</summary>
        [JsiiProperty(name: "asynchronous", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Asynchronous
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#defined_tags DatascienceJobRun#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#display_name DatascienceJobRun#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#freeform_tags DatascienceJobRun#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#id DatascienceJobRun#id}.</summary>
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

        /// <summary>job_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_configuration_override_details DatascienceJobRun#job_configuration_override_details}
        /// </remarks>
        [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobConfigurationOverrideDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobConfigurationOverrideDetails? JobConfigurationOverrideDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_environment_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_environment_configuration_override_details DatascienceJobRun#job_environment_configuration_override_details}
        /// </remarks>
        [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobEnvironmentConfigurationOverrideDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobEnvironmentConfigurationOverrideDetails? JobEnvironmentConfigurationOverrideDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_infrastructure_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_infrastructure_configuration_override_details DatascienceJobRun#job_infrastructure_configuration_override_details}
        /// </remarks>
        [JsiiProperty(name: "jobInfrastructureConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails? JobInfrastructureConfigurationOverrideDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_log_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_log_configuration_override_details DatascienceJobRun#job_log_configuration_override_details}
        /// </remarks>
        [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobLogConfigurationOverrideDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobLogConfigurationOverrideDetails? JobLogConfigurationOverrideDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_node_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_node_configuration_override_details DatascienceJobRun#job_node_configuration_override_details}
        /// </remarks>
        [JsiiProperty(name: "jobNodeConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetails? JobNodeConfigurationOverrideDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#opc_parent_rpt_url DatascienceJobRun#opc_parent_rpt_url}.</summary>
        [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpcParentRptUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#timeouts DatascienceJobRun#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobRunConfig), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJobRun.IDatascienceJobRunConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#compartment_id DatascienceJobRun#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_id DatascienceJobRun#job_id}.</summary>
            [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}")]
            public string JobId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#project_id DatascienceJobRun#project_id}.</summary>
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProjectId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#asynchronous DatascienceJobRun#asynchronous}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "asynchronous", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Asynchronous
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#defined_tags DatascienceJobRun#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#display_name DatascienceJobRun#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#freeform_tags DatascienceJobRun#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#id DatascienceJobRun#id}.</summary>
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

            /// <summary>job_configuration_override_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_configuration_override_details DatascienceJobRun#job_configuration_override_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobConfigurationOverrideDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobConfigurationOverrideDetails? JobConfigurationOverrideDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobConfigurationOverrideDetails?>();
            }

            /// <summary>job_environment_configuration_override_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_environment_configuration_override_details DatascienceJobRun#job_environment_configuration_override_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobEnvironmentConfigurationOverrideDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobEnvironmentConfigurationOverrideDetails? JobEnvironmentConfigurationOverrideDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobEnvironmentConfigurationOverrideDetails?>();
            }

            /// <summary>job_infrastructure_configuration_override_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_infrastructure_configuration_override_details DatascienceJobRun#job_infrastructure_configuration_override_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobInfrastructureConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails? JobInfrastructureConfigurationOverrideDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetails?>();
            }

            /// <summary>job_log_configuration_override_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_log_configuration_override_details DatascienceJobRun#job_log_configuration_override_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobLogConfigurationOverrideDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobLogConfigurationOverrideDetails? JobLogConfigurationOverrideDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobLogConfigurationOverrideDetails?>();
            }

            /// <summary>job_node_configuration_override_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#job_node_configuration_override_details DatascienceJobRun#job_node_configuration_override_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobNodeConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetails\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetails? JobNodeConfigurationOverrideDetails
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#opc_parent_rpt_url DatascienceJobRun#opc_parent_rpt_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opcParentRptUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpcParentRptUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#timeouts DatascienceJobRun#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunTimeouts\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunTimeouts?>();
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
