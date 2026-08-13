using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterWebAppRouting), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWebAppRouting")]
    public interface IKubernetesClusterWebAppRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/kubernetes_cluster#dns_zone_ids KubernetesCluster#dns_zone_ids}.</summary>
        [JsiiProperty(name: "dnsZoneIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsZoneIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/kubernetes_cluster#default_nginx_controller KubernetesCluster#default_nginx_controller}.</summary>
        [JsiiProperty(name: "defaultNginxController", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultNginxController
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterWebAppRouting), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWebAppRouting")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/kubernetes_cluster#dns_zone_ids KubernetesCluster#dns_zone_ids}.</summary>
            [JsiiProperty(name: "dnsZoneIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsZoneIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/kubernetes_cluster#default_nginx_controller KubernetesCluster#default_nginx_controller}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultNginxController", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultNginxController
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
