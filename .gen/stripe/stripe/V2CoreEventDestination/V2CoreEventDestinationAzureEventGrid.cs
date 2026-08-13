using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2CoreEventDestination.V2CoreEventDestinationAzureEventGrid")]
    public class V2CoreEventDestinationAzureEventGrid : stripe.V2CoreEventDestination.IV2CoreEventDestinationAzureEventGrid
    {
        /// <summary>The Azure region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_region V2CoreEventDestination#azure_region}
        /// </remarks>
        [JsiiProperty(name: "azureRegion", typeJson: "{\"primitive\":\"string\"}")]
        public string AzureRegion
        {
            get;
            set;
        }

        /// <summary>The name of the Azure resource group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_resource_group_name V2CoreEventDestination#azure_resource_group_name}
        /// </remarks>
        [JsiiProperty(name: "azureResourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public string AzureResourceGroupName
        {
            get;
            set;
        }

        /// <summary>The Azure subscription ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_subscription_id V2CoreEventDestination#azure_subscription_id}
        /// </remarks>
        [JsiiProperty(name: "azureSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public string AzureSubscriptionId
        {
            get;
            set;
        }
    }
}
