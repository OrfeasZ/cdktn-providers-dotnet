using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFluxConfiguration
{
    [JsiiByValue(fqn: "azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuild")]
    public class KubernetesFluxConfigurationKustomizationsPostBuild : azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuild
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/kubernetes_flux_configuration#substitute KubernetesFluxConfiguration#substitute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "substitute", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Substitute
        {
            get;
            set;
        }

        private object? _substituteFrom;

        /// <summary>substitute_from block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.2.0/docs/resources/kubernetes_flux_configuration#substitute_from KubernetesFluxConfiguration#substitute_from}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "substituteFrom", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesFluxConfiguration.KubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SubstituteFrom
        {
            get => _substituteFrom;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.KubernetesFluxConfiguration.IKubernetesFluxConfigurationKustomizationsPostBuildSubstituteFrom).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _substituteFrom = value;
            }
        }
    }
}
