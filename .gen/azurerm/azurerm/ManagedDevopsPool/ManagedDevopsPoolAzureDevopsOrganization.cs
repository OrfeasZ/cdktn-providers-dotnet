using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganization")]
    public class ManagedDevopsPoolAzureDevopsOrganization : azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganization
    {
        private object _organization;

        /// <summary>organization block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#organization ManagedDevopsPool#organization}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "organization", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganization\"},\"kind\":\"array\"}}]}}")]
        public object Organization
        {
            get => _organization;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _organization = value;
            }
        }

        /// <summary>permission block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/managed_devops_pool#permission ManagedDevopsPool#permission}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permission", typeJson: "{\"fqn\":\"azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationPermission\"}", isOptional: true)]
        public azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationPermission? Permission
        {
            get;
            set;
        }
    }
}
