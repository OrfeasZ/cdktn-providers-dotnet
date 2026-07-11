using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedDevopsPool
{
    [JsiiInterface(nativeType: typeof(IManagedDevopsPoolAzureDevopsOrganizationOrganization), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganization")]
    public interface IManagedDevopsPoolAzureDevopsOrganizationOrganization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#parallelism ManagedDevopsPool#parallelism}.</summary>
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}")]
        double Parallelism
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#url ManagedDevopsPool#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        string Url
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#projects ManagedDevopsPool#projects}.</summary>
        [JsiiProperty(name: "projects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Projects
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedDevopsPoolAzureDevopsOrganizationOrganization), fullyQualifiedName: "azurerm.managedDevopsPool.ManagedDevopsPoolAzureDevopsOrganizationOrganization")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedDevopsPool.IManagedDevopsPoolAzureDevopsOrganizationOrganization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#parallelism ManagedDevopsPool#parallelism}.</summary>
            [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}")]
            public double Parallelism
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#url ManagedDevopsPool#url}.</summary>
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
            public string Url
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/resources/managed_devops_pool#projects ManagedDevopsPool#projects}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "projects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Projects
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
