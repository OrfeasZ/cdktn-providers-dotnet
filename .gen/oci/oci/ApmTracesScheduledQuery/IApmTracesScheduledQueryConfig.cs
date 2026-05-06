using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmTracesScheduledQuery
{
    [JsiiInterface(nativeType: typeof(IApmTracesScheduledQueryConfig), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryConfig")]
    public interface IApmTracesScheduledQueryConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#apm_domain_id ApmTracesScheduledQuery#apm_domain_id}.</summary>
        [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
        string ApmDomainId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#defined_tags ApmTracesScheduledQuery#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#freeform_tags ApmTracesScheduledQuery#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#id ApmTracesScheduledQuery#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#opc_dry_run ApmTracesScheduledQuery#opc_dry_run}.</summary>
        [JsiiProperty(name: "opcDryRun", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OpcDryRun
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_description ApmTracesScheduledQuery#scheduled_query_description}.</summary>
        [JsiiProperty(name: "scheduledQueryDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQueryDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_maximum_runtime_in_seconds ApmTracesScheduledQuery#scheduled_query_maximum_runtime_in_seconds}.</summary>
        [JsiiProperty(name: "scheduledQueryMaximumRuntimeInSeconds", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQueryMaximumRuntimeInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_name ApmTracesScheduledQuery#scheduled_query_name}.</summary>
        [JsiiProperty(name: "scheduledQueryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQueryName
        {
            get
            {
                return null;
            }
        }

        /// <summary>scheduled_query_processing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_processing_configuration ApmTracesScheduledQuery#scheduled_query_processing_configuration}
        /// </remarks>
        [JsiiProperty(name: "scheduledQueryProcessingConfiguration", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration? ScheduledQueryProcessingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_processing_sub_type ApmTracesScheduledQuery#scheduled_query_processing_sub_type}.</summary>
        [JsiiProperty(name: "scheduledQueryProcessingSubType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQueryProcessingSubType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_processing_type ApmTracesScheduledQuery#scheduled_query_processing_type}.</summary>
        [JsiiProperty(name: "scheduledQueryProcessingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQueryProcessingType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_retention_criteria ApmTracesScheduledQuery#scheduled_query_retention_criteria}.</summary>
        [JsiiProperty(name: "scheduledQueryRetentionCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQueryRetentionCriteria
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_retention_period_in_ms ApmTracesScheduledQuery#scheduled_query_retention_period_in_ms}.</summary>
        [JsiiProperty(name: "scheduledQueryRetentionPeriodInMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQueryRetentionPeriodInMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_schedule ApmTracesScheduledQuery#scheduled_query_schedule}.</summary>
        [JsiiProperty(name: "scheduledQuerySchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQuerySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_text ApmTracesScheduledQuery#scheduled_query_text}.</summary>
        [JsiiProperty(name: "scheduledQueryText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduledQueryText
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#timeouts ApmTracesScheduledQuery#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmTracesScheduledQueryConfig), fullyQualifiedName: "oci.apmTracesScheduledQuery.ApmTracesScheduledQueryConfig")]
        internal sealed class _Proxy : DeputyBase, oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#apm_domain_id ApmTracesScheduledQuery#apm_domain_id}.</summary>
            [JsiiProperty(name: "apmDomainId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApmDomainId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#defined_tags ApmTracesScheduledQuery#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#freeform_tags ApmTracesScheduledQuery#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#id ApmTracesScheduledQuery#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#opc_dry_run ApmTracesScheduledQuery#opc_dry_run}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "opcDryRun", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OpcDryRun
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_description ApmTracesScheduledQuery#scheduled_query_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQueryDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_maximum_runtime_in_seconds ApmTracesScheduledQuery#scheduled_query_maximum_runtime_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryMaximumRuntimeInSeconds", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQueryMaximumRuntimeInSeconds
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_name ApmTracesScheduledQuery#scheduled_query_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQueryName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scheduled_query_processing_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_processing_configuration ApmTracesScheduledQuery#scheduled_query_processing_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryProcessingConfiguration", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryScheduledQueryProcessingConfiguration\"}", isOptional: true)]
            public oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration? ScheduledQueryProcessingConfiguration
            {
                get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryScheduledQueryProcessingConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_processing_sub_type ApmTracesScheduledQuery#scheduled_query_processing_sub_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryProcessingSubType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQueryProcessingSubType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_processing_type ApmTracesScheduledQuery#scheduled_query_processing_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryProcessingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQueryProcessingType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_retention_criteria ApmTracesScheduledQuery#scheduled_query_retention_criteria}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryRetentionCriteria", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQueryRetentionCriteria
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_retention_period_in_ms ApmTracesScheduledQuery#scheduled_query_retention_period_in_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryRetentionPeriodInMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQueryRetentionPeriodInMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_schedule ApmTracesScheduledQuery#scheduled_query_schedule}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQuerySchedule", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQuerySchedule
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#scheduled_query_text ApmTracesScheduledQuery#scheduled_query_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduledQueryText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduledQueryText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_traces_scheduled_query#timeouts ApmTracesScheduledQuery#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.apmTracesScheduledQuery.ApmTracesScheduledQueryTimeouts\"}", isOptional: true)]
            public oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.ApmTracesScheduledQuery.IApmTracesScheduledQueryTimeouts?>();
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
