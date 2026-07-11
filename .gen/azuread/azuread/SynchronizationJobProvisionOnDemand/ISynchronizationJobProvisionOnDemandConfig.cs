using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.SynchronizationJobProvisionOnDemand
{
    [JsiiInterface(nativeType: typeof(ISynchronizationJobProvisionOnDemandConfig), fullyQualifiedName: "azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandConfig")]
    public interface ISynchronizationJobProvisionOnDemandConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#parameter SynchronizationJobProvisionOnDemand#parameter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameter\"},\"kind\":\"array\"}}]}}")]
        object Parameter
        {
            get;
        }

        /// <summary>The object ID of the service principal for which this synchronization job should be provisioned.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#service_principal_id SynchronizationJobProvisionOnDemand#service_principal_id}
        /// </remarks>
        [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
        string ServicePrincipalId
        {
            get;
        }

        /// <summary>The identifier for the synchronization jop.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#synchronization_job_id SynchronizationJobProvisionOnDemand#synchronization_job_id}
        /// </remarks>
        [JsiiProperty(name: "synchronizationJobId", typeJson: "{\"primitive\":\"string\"}")]
        string SynchronizationJobId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#id SynchronizationJobProvisionOnDemand#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#timeouts SynchronizationJobProvisionOnDemand#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#triggers SynchronizationJobProvisionOnDemand#triggers}.</summary>
        [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Triggers
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISynchronizationJobProvisionOnDemandConfig), fullyQualifiedName: "azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandConfig")]
        internal sealed class _Proxy : DeputyBase, azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#parameter SynchronizationJobProvisionOnDemand#parameter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandParameter" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "parameter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandParameter\"},\"kind\":\"array\"}}]}}")]
            public object Parameter
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>The object ID of the service principal for which this synchronization job should be provisioned.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#service_principal_id SynchronizationJobProvisionOnDemand#service_principal_id}
            /// </remarks>
            [JsiiProperty(name: "servicePrincipalId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServicePrincipalId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The identifier for the synchronization jop.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#synchronization_job_id SynchronizationJobProvisionOnDemand#synchronization_job_id}
            /// </remarks>
            [JsiiProperty(name: "synchronizationJobId", typeJson: "{\"primitive\":\"string\"}")]
            public string SynchronizationJobId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#id SynchronizationJobProvisionOnDemand#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#timeouts SynchronizationJobProvisionOnDemand#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azuread.synchronizationJobProvisionOnDemand.SynchronizationJobProvisionOnDemandTimeouts\"}", isOptional: true)]
            public azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandTimeouts? Timeouts
            {
                get => GetInstanceProperty<azuread.SynchronizationJobProvisionOnDemand.ISynchronizationJobProvisionOnDemandTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/synchronization_job_provision_on_demand#triggers SynchronizationJobProvisionOnDemand#triggers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "triggers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Triggers
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
