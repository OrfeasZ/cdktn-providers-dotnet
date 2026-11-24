using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApi
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiImportWsdlSelector), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiImportWsdlSelector")]
    public interface IApiManagementApiImportWsdlSelector
    {
        /// <summary>The name of endpoint (port) to import from WSDL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#endpoint_name ApiManagementApi#endpoint_name}
        /// </remarks>
        [JsiiProperty(name: "endpointName", typeJson: "{\"primitive\":\"string\"}")]
        string EndpointName
        {
            get;
        }

        /// <summary>The name of service to import from WSDL.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#service_name ApiManagementApi#service_name}
        /// </remarks>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiImportWsdlSelector), fullyQualifiedName: "azurerm.apiManagementApi.ApiManagementApiImportWsdlSelector")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApi.IApiManagementApiImportWsdlSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of endpoint (port) to import from WSDL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#endpoint_name ApiManagementApi#endpoint_name}
            /// </remarks>
            [JsiiProperty(name: "endpointName", typeJson: "{\"primitive\":\"string\"}")]
            public string EndpointName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of service to import from WSDL.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api#service_name ApiManagementApi#service_name}
            /// </remarks>
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
