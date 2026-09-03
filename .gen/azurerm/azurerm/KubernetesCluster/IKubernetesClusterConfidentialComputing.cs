using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterConfidentialComputing), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterConfidentialComputing")]
    public interface IKubernetesClusterConfidentialComputing
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#sgx_quote_helper_enabled KubernetesCluster#sgx_quote_helper_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "sgxQuoteHelperEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object SgxQuoteHelperEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterConfidentialComputing), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterConfidentialComputing")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterConfidentialComputing
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_cluster#sgx_quote_helper_enabled KubernetesCluster#sgx_quote_helper_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "sgxQuoteHelperEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object SgxQuoteHelperEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
