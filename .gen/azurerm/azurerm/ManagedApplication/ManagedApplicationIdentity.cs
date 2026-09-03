using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedApplication.ManagedApplicationIdentity")]
    public class ManagedApplicationIdentity : azurerm.ManagedApplication.IManagedApplicationIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_application#type ManagedApplication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/managed_application#identity_ids ManagedApplication#identity_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IdentityIds
        {
            get;
            set;
        }
    }
}
