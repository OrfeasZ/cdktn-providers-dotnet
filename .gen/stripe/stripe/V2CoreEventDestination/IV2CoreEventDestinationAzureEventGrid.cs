using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    [JsiiInterface(nativeType: typeof(IV2CoreEventDestinationAzureEventGrid), fullyQualifiedName: "stripe.v2CoreEventDestination.V2CoreEventDestinationAzureEventGrid")]
    public interface IV2CoreEventDestinationAzureEventGrid
    {
        /// <summary>The Azure region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_region V2CoreEventDestination#azure_region}
        /// </remarks>
        [JsiiProperty(name: "azureRegion", typeJson: "{\"primitive\":\"string\"}")]
        string AzureRegion
        {
            get;
        }

        /// <summary>The name of the Azure resource group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_resource_group_name V2CoreEventDestination#azure_resource_group_name}
        /// </remarks>
        [JsiiProperty(name: "azureResourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string AzureResourceGroupName
        {
            get;
        }

        /// <summary>The Azure subscription ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_subscription_id V2CoreEventDestination#azure_subscription_id}
        /// </remarks>
        [JsiiProperty(name: "azureSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        string AzureSubscriptionId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IV2CoreEventDestinationAzureEventGrid), fullyQualifiedName: "stripe.v2CoreEventDestination.V2CoreEventDestinationAzureEventGrid")]
        internal sealed class _Proxy : DeputyBase, stripe.V2CoreEventDestination.IV2CoreEventDestinationAzureEventGrid
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Azure region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_region V2CoreEventDestination#azure_region}
            /// </remarks>
            [JsiiProperty(name: "azureRegion", typeJson: "{\"primitive\":\"string\"}")]
            public string AzureRegion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the Azure resource group.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_resource_group_name V2CoreEventDestination#azure_resource_group_name}
            /// </remarks>
            [JsiiProperty(name: "azureResourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string AzureResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The Azure subscription ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/v2_core_event_destination#azure_subscription_id V2CoreEventDestination#azure_subscription_id}
            /// </remarks>
            [JsiiProperty(name: "azureSubscriptionId", typeJson: "{\"primitive\":\"string\"}")]
            public string AzureSubscriptionId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
