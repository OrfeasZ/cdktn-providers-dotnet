using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesAutomaticClusterPrivateCluster), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateCluster")]
    public interface IKubernetesAutomaticClusterPrivateCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#private_dns_zone_id KubernetesAutomaticCluster#private_dns_zone_id}.</summary>
        [JsiiProperty(name: "privateDnsZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateDnsZoneId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#public_fully_qualified_domain_name_enabled KubernetesAutomaticCluster#public_fully_qualified_domain_name_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "publicFullyQualifiedDomainNameEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicFullyQualifiedDomainNameEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesAutomaticClusterPrivateCluster), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterPrivateCluster")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterPrivateCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#private_dns_zone_id KubernetesAutomaticCluster#private_dns_zone_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateDnsZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateDnsZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/kubernetes_automatic_cluster#public_fully_qualified_domain_name_enabled KubernetesAutomaticCluster#public_fully_qualified_domain_name_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicFullyQualifiedDomainNameEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PublicFullyQualifiedDomainNameEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
