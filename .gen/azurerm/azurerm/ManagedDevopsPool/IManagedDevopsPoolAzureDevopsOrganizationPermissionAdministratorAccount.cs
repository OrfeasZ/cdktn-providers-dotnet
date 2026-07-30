using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount")]
    public interface IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#groups ManagedDevopsPool#groups}.</summary>
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Groups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#users ManagedDevopsPool#users}.</summary>
        [JsiiProperty(name: "users", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Users
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermissionAdministratorAccount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#groups ManagedDevopsPool#groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Groups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#users ManagedDevopsPool#users}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "users", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Users
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
