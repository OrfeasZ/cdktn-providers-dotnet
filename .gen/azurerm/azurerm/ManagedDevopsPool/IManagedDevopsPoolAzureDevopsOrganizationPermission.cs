using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolAzureDevopsOrganizationPermission), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission")]
    public interface IManagedDevopsPoolAzureDevopsOrganizationPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#kind ManagedDevopsPool#kind}.</summary>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>administrator_account block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#administrator_account ManagedDevopsPool#administrator_account}
        /// </remarks>
        [JsiiProperty(name: "administratorAccount", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount? AdministratorAccount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolAzureDevopsOrganizationPermission), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#kind ManagedDevopsPool#kind}.</summary>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>administrator_account block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#administrator_account ManagedDevopsPool#administrator_account}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "administratorAccount", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount\"}", isOptional: true)]
            public azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount? AdministratorAccount
            {
                get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount?>();
            }
        }
    }
}
