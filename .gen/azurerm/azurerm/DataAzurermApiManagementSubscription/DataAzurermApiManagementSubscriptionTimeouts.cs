using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementSubscription
{
    [JsiiByValue(fqn: "azurerm.dataAzurermApiManagementSubscription.DataAzurermApiManagementSubscriptionTimeouts")]
    public class DataAzurermApiManagementSubscriptionTimeouts : azurerm.DataAzurermApiManagementSubscription.IDataAzurermApiManagementSubscriptionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/data-sources/api_management_subscription#read DataAzurermApiManagementSubscription#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
