using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementGateway
{
    [JsiiInterface(nativeType: typeof(IApiManagementGatewayLocationData), fullyQualifiedName: "azurerm.apiManagementGateway.ApiManagementGatewayLocationData")]
    public interface IApiManagementGatewayLocationData
    {
        /// <summary>A canonical name for the geographic or physical location.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#name ApiManagementGateway#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>The city or locality where the resource is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#city ApiManagementGateway#city}
        /// </remarks>
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? City
        {
            get
            {
                return null;
            }
        }

        /// <summary>The district, state, or province where the resource is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#district ApiManagementGateway#district}
        /// </remarks>
        [JsiiProperty(name: "district", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? District
        {
            get
            {
                return null;
            }
        }

        /// <summary>The country or region where the resource is located.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#region ApiManagementGateway#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementGatewayLocationData), fullyQualifiedName: "azurerm.apiManagementGateway.ApiManagementGatewayLocationData")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementGateway.IApiManagementGatewayLocationData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A canonical name for the geographic or physical location.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#name ApiManagementGateway#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The city or locality where the resource is located.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#city ApiManagementGateway#city}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? City
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The district, state, or province where the resource is located.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#district ApiManagementGateway#district}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "district", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? District
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The country or region where the resource is located.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_gateway#region ApiManagementGateway#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
