using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiDiagnosticBackendResponseDataMaskingHeaders), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMaskingHeaders")]
    public interface IApiManagementApiDiagnosticBackendResponseDataMaskingHeaders
    {
        /// <summary>The data masking mode.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#mode ApiManagementApiDiagnostic#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        string Mode
        {
            get;
        }

        /// <summary>The name of the header or the query parameter to mask.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#value ApiManagementApiDiagnostic#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiDiagnosticBackendResponseDataMaskingHeaders), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponseDataMaskingHeaders")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponseDataMaskingHeaders
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The data masking mode.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#mode ApiManagementApiDiagnostic#mode}
            /// </remarks>
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
            public string Mode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the header or the query parameter to mask.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#value ApiManagementApiDiagnostic#value}
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
