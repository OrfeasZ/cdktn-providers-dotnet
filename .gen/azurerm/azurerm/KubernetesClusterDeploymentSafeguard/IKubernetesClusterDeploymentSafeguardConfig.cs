using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesClusterDeploymentSafeguard
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterDeploymentSafeguardConfig), fullyQualifiedName: "azurerm.kubernetesClusterDeploymentSafeguard.KubernetesClusterDeploymentSafeguardConfig")]
    public interface IKubernetesClusterDeploymentSafeguardConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#kubernetes_cluster_id KubernetesClusterDeploymentSafeguard#kubernetes_cluster_id}.</summary>
        [JsiiProperty(name: "kubernetesClusterId", typeJson: "{\"primitive\":\"string\"}")]
        string KubernetesClusterId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#level KubernetesClusterDeploymentSafeguard#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
        string Level
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#excluded_namespaces KubernetesClusterDeploymentSafeguard#excluded_namespaces}.</summary>
        [JsiiProperty(name: "excludedNamespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludedNamespaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#id KubernetesClusterDeploymentSafeguard#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#pod_security_standards_level KubernetesClusterDeploymentSafeguard#pod_security_standards_level}.</summary>
        [JsiiProperty(name: "podSecurityStandardsLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PodSecurityStandardsLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#timeouts KubernetesClusterDeploymentSafeguard#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesClusterDeploymentSafeguard.KubernetesClusterDeploymentSafeguardTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesClusterDeploymentSafeguard.IKubernetesClusterDeploymentSafeguardTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterDeploymentSafeguardConfig), fullyQualifiedName: "azurerm.kubernetesClusterDeploymentSafeguard.KubernetesClusterDeploymentSafeguardConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesClusterDeploymentSafeguard.IKubernetesClusterDeploymentSafeguardConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#kubernetes_cluster_id KubernetesClusterDeploymentSafeguard#kubernetes_cluster_id}.</summary>
            [JsiiProperty(name: "kubernetesClusterId", typeJson: "{\"primitive\":\"string\"}")]
            public string KubernetesClusterId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#level KubernetesClusterDeploymentSafeguard#level}.</summary>
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}")]
            public string Level
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#excluded_namespaces KubernetesClusterDeploymentSafeguard#excluded_namespaces}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludedNamespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludedNamespaces
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#id KubernetesClusterDeploymentSafeguard#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#pod_security_standards_level KubernetesClusterDeploymentSafeguard#pod_security_standards_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "podSecurityStandardsLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PodSecurityStandardsLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/kubernetes_cluster_deployment_safeguard#timeouts KubernetesClusterDeploymentSafeguard#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.kubernetesClusterDeploymentSafeguard.KubernetesClusterDeploymentSafeguardTimeouts\"}", isOptional: true)]
            public azurerm.KubernetesClusterDeploymentSafeguard.IKubernetesClusterDeploymentSafeguardTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.KubernetesClusterDeploymentSafeguard.IKubernetesClusterDeploymentSafeguardTimeouts?>();
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
