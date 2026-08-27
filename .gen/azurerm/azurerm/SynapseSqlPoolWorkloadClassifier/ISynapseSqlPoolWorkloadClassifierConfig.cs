using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SynapseSqlPoolWorkloadClassifier
{
    [JsiiInterface(nativeType: typeof(ISynapseSqlPoolWorkloadClassifierConfig), fullyQualifiedName: "azurerm.synapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifierConfig")]
    public interface ISynapseSqlPoolWorkloadClassifierConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#member_name SynapseSqlPoolWorkloadClassifier#member_name}.</summary>
        [JsiiProperty(name: "memberName", typeJson: "{\"primitive\":\"string\"}")]
        string MemberName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#name SynapseSqlPoolWorkloadClassifier#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#workload_group_id SynapseSqlPoolWorkloadClassifier#workload_group_id}.</summary>
        [JsiiProperty(name: "workloadGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string WorkloadGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#context SynapseSqlPoolWorkloadClassifier#context}.</summary>
        [JsiiProperty(name: "context", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Context
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#end_time SynapseSqlPoolWorkloadClassifier#end_time}.</summary>
        [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#id SynapseSqlPoolWorkloadClassifier#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#importance SynapseSqlPoolWorkloadClassifier#importance}.</summary>
        [JsiiProperty(name: "importance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Importance
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#label SynapseSqlPoolWorkloadClassifier#label}.</summary>
        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Label
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#start_time SynapseSqlPoolWorkloadClassifier#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#timeouts SynapseSqlPoolWorkloadClassifier#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifierTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.SynapseSqlPoolWorkloadClassifier.ISynapseSqlPoolWorkloadClassifierTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISynapseSqlPoolWorkloadClassifierConfig), fullyQualifiedName: "azurerm.synapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifierConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.SynapseSqlPoolWorkloadClassifier.ISynapseSqlPoolWorkloadClassifierConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#member_name SynapseSqlPoolWorkloadClassifier#member_name}.</summary>
            [JsiiProperty(name: "memberName", typeJson: "{\"primitive\":\"string\"}")]
            public string MemberName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#name SynapseSqlPoolWorkloadClassifier#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#workload_group_id SynapseSqlPoolWorkloadClassifier#workload_group_id}.</summary>
            [JsiiProperty(name: "workloadGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string WorkloadGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#context SynapseSqlPoolWorkloadClassifier#context}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "context", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Context
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#end_time SynapseSqlPoolWorkloadClassifier#end_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#id SynapseSqlPoolWorkloadClassifier#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#importance SynapseSqlPoolWorkloadClassifier#importance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "importance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Importance
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#label SynapseSqlPoolWorkloadClassifier#label}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Label
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#start_time SynapseSqlPoolWorkloadClassifier#start_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/synapse_sql_pool_workload_classifier#timeouts SynapseSqlPoolWorkloadClassifier#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.synapseSqlPoolWorkloadClassifier.SynapseSqlPoolWorkloadClassifierTimeouts\"}", isOptional: true)]
            public azurerm.SynapseSqlPoolWorkloadClassifier.ISynapseSqlPoolWorkloadClassifierTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.SynapseSqlPoolWorkloadClassifier.ISynapseSqlPoolWorkloadClassifierTimeouts?>();
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
