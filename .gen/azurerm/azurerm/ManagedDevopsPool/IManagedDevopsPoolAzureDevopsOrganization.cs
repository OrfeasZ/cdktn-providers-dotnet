using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolAzureDevopsOrganization), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganization")]
    public interface IManagedDevopsPoolAzureDevopsOrganization
    {
        /// <summary>organization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#organization ManagedDevopsPool#organization}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "organization", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganization\"},\"kind\":\"array\"}}]}}")]
        object Organization
        {
            get;
        }

        /// <summary>permission block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#permission ManagedDevopsPool#permission}
        /// </remarks>
        [JsiiProperty(name: "permission", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission? Permission
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolAzureDevopsOrganization), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganization")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>organization block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#organization ManagedDevopsPool#organization}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "organization", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganization\"},\"kind\":\"array\"}}]}}")]
            public object Organization
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>permission block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/managed_devops_pool#permission ManagedDevopsPool#permission}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permission", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission\"}", isOptional: true)]
            public azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission? Permission
            {
                get => GetInstanceProperty<azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission?>();
            }
        }
    }
}
