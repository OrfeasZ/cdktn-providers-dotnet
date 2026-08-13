using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission")]
    public class ManagedDevopsPoolAzureDevopsOrganizationPermission : azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_devops_pool#kind ManagedDevopsPool#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>administrator_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/managed_devops_pool#administrator_account ManagedDevopsPool#administrator_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "administratorAccount", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount\"}", isOptional: true)]
        public azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount? AdministratorAccount
        {
            get;
            set;
        }
    }
}
