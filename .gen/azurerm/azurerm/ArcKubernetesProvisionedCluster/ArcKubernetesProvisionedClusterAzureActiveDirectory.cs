using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesProvisionedCluster
{
    [JsiiByValue(fqn: "azurerm.arcKubernetesProvisionedCluster.ArcKubernetesProvisionedClusterAzureActiveDirectory")]
    public class ArcKubernetesProvisionedClusterAzureActiveDirectory : azurerm.ArcKubernetesProvisionedCluster.IArcKubernetesProvisionedClusterAzureActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_kubernetes_provisioned_cluster#admin_group_object_ids ArcKubernetesProvisionedCluster#admin_group_object_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adminGroupObjectIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdminGroupObjectIds
        {
            get;
            set;
        }

        private object? _azureRbacEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_kubernetes_provisioned_cluster#azure_rbac_enabled ArcKubernetesProvisionedCluster#azure_rbac_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "azureRbacEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AzureRbacEnabled
        {
            get => _azureRbacEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _azureRbacEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/arc_kubernetes_provisioned_cluster#tenant_id ArcKubernetesProvisionedCluster#tenant_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TenantId
        {
            get;
            set;
        }
    }
}
