using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetUpdateRun
{
    [JsiiInterface(nativeType: typeof(IKubernetesFleetUpdateRunConfig), fullyQualifiedName: "azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunConfig")]
    public interface IKubernetesFleetUpdateRunConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#kubernetes_fleet_manager_id KubernetesFleetUpdateRun#kubernetes_fleet_manager_id}.</summary>
        [JsiiProperty(name: "kubernetesFleetManagerId", typeJson: "{\"primitive\":\"string\"}")]
        string KubernetesFleetManagerId
        {
            get;
        }

        /// <summary>managed_cluster_update block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#managed_cluster_update KubernetesFleetUpdateRun#managed_cluster_update}
        /// </remarks>
        [JsiiProperty(name: "managedClusterUpdate", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdate\"}")]
        azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate ManagedClusterUpdate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#name KubernetesFleetUpdateRun#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#fleet_update_strategy_id KubernetesFleetUpdateRun#fleet_update_strategy_id}.</summary>
        [JsiiProperty(name: "fleetUpdateStrategyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FleetUpdateStrategyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#id KubernetesFleetUpdateRun#id}.</summary>
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

        /// <summary>stage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#stage KubernetesFleetUpdateRun#stage}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunStage" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "stage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunStage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Stage
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#timeouts KubernetesFleetUpdateRun#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesFleetUpdateRunConfig), fullyQualifiedName: "azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#kubernetes_fleet_manager_id KubernetesFleetUpdateRun#kubernetes_fleet_manager_id}.</summary>
            [JsiiProperty(name: "kubernetesFleetManagerId", typeJson: "{\"primitive\":\"string\"}")]
            public string KubernetesFleetManagerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>managed_cluster_update block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#managed_cluster_update KubernetesFleetUpdateRun#managed_cluster_update}
            /// </remarks>
            [JsiiProperty(name: "managedClusterUpdate", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunManagedClusterUpdate\"}")]
            public azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate ManagedClusterUpdate
            {
                get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunManagedClusterUpdate>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#name KubernetesFleetUpdateRun#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#fleet_update_strategy_id KubernetesFleetUpdateRun#fleet_update_strategy_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fleetUpdateStrategyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FleetUpdateStrategyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#id KubernetesFleetUpdateRun#id}.</summary>
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

            /// <summary>stage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#stage KubernetesFleetUpdateRun#stage}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunStage" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunStage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Stage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/kubernetes_fleet_update_run#timeouts KubernetesFleetUpdateRun#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesFleetUpdateRun.KubernetesFleetUpdateRunTimeouts\"}", isOptional: true)]
            public azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.KubernetesFleetUpdateRun.IKubernetesFleetUpdateRunTimeouts?>();
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
