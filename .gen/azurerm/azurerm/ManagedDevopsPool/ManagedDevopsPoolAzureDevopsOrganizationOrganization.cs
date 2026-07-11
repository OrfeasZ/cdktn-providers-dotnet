using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganization")]
    public class ManagedDevopsPoolAzureDevopsOrganizationOrganization : azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#parallelism ManagedDevopsPool#parallelism}.</summary>
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}")]
        public double Parallelism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#url ManagedDevopsPool#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#projects ManagedDevopsPool#projects}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "projects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Projects
        {
            get;
            set;
        }
    }
}
