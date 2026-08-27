using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesProvisionedCluster
{
    [JsiiInterface(nativeType: typeof(IArcKubernetesProvisionedClusterAzureActiveDirectory), fullyQualifiedName: "azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterAzureActiveDirectory")]
    public interface IArcKubernetesProvisionedClusterAzureActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/arc_kubernetes_provisioned_cluster#admin_group_object_ids ArcKubernetesProvisionedCluster#admin_group_object_ids}.</summary>
        [JsiiProperty(name: "adminGroupObjectIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdminGroupObjectIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/arc_kubernetes_provisioned_cluster#azure_rbac_enabled ArcKubernetesProvisionedCluster#azure_rbac_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "azureRbacEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AzureRbacEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/arc_kubernetes_provisioned_cluster#tenant_id ArcKubernetesProvisionedCluster#tenant_id}.</summary>
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TenantId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IArcKubernetesProvisionedClusterAzureActiveDirectory), fullyQualifiedName: "azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterAzureActiveDirectory")]
        internal sealed class _Proxy : DeputyBase, azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterAzureActiveDirectory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/arc_kubernetes_provisioned_cluster#admin_group_object_ids ArcKubernetesProvisionedCluster#admin_group_object_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adminGroupObjectIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdminGroupObjectIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/arc_kubernetes_provisioned_cluster#azure_rbac_enabled ArcKubernetesProvisionedCluster#azure_rbac_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureRbacEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AzureRbacEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/arc_kubernetes_provisioned_cluster#tenant_id ArcKubernetesProvisionedCluster#tenant_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TenantId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
