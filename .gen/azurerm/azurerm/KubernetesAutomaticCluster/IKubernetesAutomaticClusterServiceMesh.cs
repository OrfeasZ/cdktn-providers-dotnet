using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesAutomaticCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesAutomaticClusterServiceMesh), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMesh")]
    public interface IKubernetesAutomaticClusterServiceMesh
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#revisions KubernetesAutomaticCluster#revisions}.</summary>
        [JsiiProperty(name: "revisions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Revisions
        {
            get;
        }

        /// <summary>certificate_authority block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#certificate_authority KubernetesAutomaticCluster#certificate_authority}
        /// </remarks>
        [JsiiProperty(name: "certificateAuthority", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshCertificateAuthority\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMeshCertificateAuthority? CertificateAuthority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#external_ingress_gateway_enabled KubernetesAutomaticCluster#external_ingress_gateway_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "externalIngressGatewayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalIngressGatewayEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#internal_ingress_gateway_enabled KubernetesAutomaticCluster#internal_ingress_gateway_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "internalIngressGatewayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InternalIngressGatewayEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#proxy_redirect_mechanism KubernetesAutomaticCluster#proxy_redirect_mechanism}.</summary>
        [JsiiProperty(name: "proxyRedirectMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProxyRedirectMechanism
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesAutomaticClusterServiceMesh), fullyQualifiedName: "azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMesh")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMesh
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#revisions KubernetesAutomaticCluster#revisions}.</summary>
            [JsiiProperty(name: "revisions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Revisions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>certificate_authority block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#certificate_authority KubernetesAutomaticCluster#certificate_authority}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthority", typeJson: "{\"fqn\":\"azurerm.kubernetesAutomaticCluster.KubernetesAutomaticClusterServiceMeshCertificateAuthority\"}", isOptional: true)]
            public azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMeshCertificateAuthority? CertificateAuthority
            {
                get => GetInstanceProperty<azurerm.KubernetesAutomaticCluster.IKubernetesAutomaticClusterServiceMeshCertificateAuthority?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#external_ingress_gateway_enabled KubernetesAutomaticCluster#external_ingress_gateway_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalIngressGatewayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExternalIngressGatewayEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#internal_ingress_gateway_enabled KubernetesAutomaticCluster#internal_ingress_gateway_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "internalIngressGatewayEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? InternalIngressGatewayEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/kubernetes_automatic_cluster#proxy_redirect_mechanism KubernetesAutomaticCluster#proxy_redirect_mechanism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "proxyRedirectMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProxyRedirectMechanism
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
