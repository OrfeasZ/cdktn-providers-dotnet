using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementSubscription
{
    [JsiiInterface(nativeType: typeof(IDataAzurermApiManagementSubscriptionTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementSubscription.DataAzurermApiManagementSubscriptionTimeouts")]
    public interface IDataAzurermApiManagementSubscriptionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/api_management_subscription#read DataAzurermApiManagementSubscription#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermApiManagementSubscriptionTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementSubscription.DataAzurermApiManagementSubscriptionTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermApiManagementSubscription.IDataAzurermApiManagementSubscriptionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.80.0/docs/data-sources/api_management_subscription#read DataAzurermApiManagementSubscription#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
