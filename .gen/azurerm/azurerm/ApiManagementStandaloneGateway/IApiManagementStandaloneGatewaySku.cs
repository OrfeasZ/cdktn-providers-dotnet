using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementStandaloneGateway
{
    [JsiiInterface(nativeType: typeof(IApiManagementStandaloneGatewaySku), fullyQualifiedName: "azurerm.apiManagementStandaloneGateway.ApiManagementStandaloneGatewaySku")]
    public interface IApiManagementStandaloneGatewaySku
    {
        /// <summary>The name of the SKU.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_standalone_gateway#name ApiManagementStandaloneGateway#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The number of deployed units of the SKU.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_standalone_gateway#capacity ApiManagementStandaloneGateway#capacity}
        /// </remarks>
        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Capacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementStandaloneGatewaySku), fullyQualifiedName: "azurerm.apiManagementStandaloneGateway.ApiManagementStandaloneGatewaySku")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementStandaloneGateway.IApiManagementStandaloneGatewaySku
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the SKU.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_standalone_gateway#name ApiManagementStandaloneGateway#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The number of deployed units of the SKU.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_standalone_gateway#capacity ApiManagementStandaloneGateway#capacity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Capacity
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
