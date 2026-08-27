using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFluxConfiguration
{
    [JsiiInterface(nativeType: typeof(IKubernetesFluxConfigurationKustomizationsPostBuild), fullyQualifiedName: "azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuild")]
    public interface IKubernetesFluxConfigurationKustomizationsPostBuild
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_flux_configuration#substitute KubernetesFluxConfiguration#substitute}.</summary>
        [JsiiProperty(name: "substitute", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Substitute
        {
            get
            {
                return null;
            }
        }

        /// <summary>substitute_from block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_flux_configuration#substitute_from KubernetesFluxConfiguration#substitute_from}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "substituteFrom", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SubstituteFrom
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesFluxConfigurationKustomizationsPostBuild), fullyQualifiedName: "azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuild")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuild
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_flux_configuration#substitute KubernetesFluxConfiguration#substitute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "substitute", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Substitute
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>substitute_from block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_flux_configuration#substitute_from KubernetesFluxConfiguration#substitute_from}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "substituteFrom", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SubstituteFrom
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
