using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementDiagnostic
{
    [JsiiInterface(nativeType: typeof(IApiManagementDiagnosticFrontendRequest), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequest")]
    public interface IApiManagementDiagnosticFrontendRequest
    {
        /// <summary>Number of payload bytes to log (up to 8192).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#body_bytes ApiManagementDiagnostic#body_bytes}
        /// </remarks>
        [JsiiProperty(name: "bodyBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BodyBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_masking block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#data_masking ApiManagementDiagnostic#data_masking}
        /// </remarks>
        [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequestDataMasking\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMasking? DataMasking
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of headers to log.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#headers_to_log ApiManagementDiagnostic#headers_to_log}
        /// </remarks>
        [JsiiProperty(name: "headersToLog", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HeadersToLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementDiagnosticFrontendRequest), fullyQualifiedName: "azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequest")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number of payload bytes to log (up to 8192).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#body_bytes ApiManagementDiagnostic#body_bytes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bodyBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BodyBytes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>data_masking block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#data_masking ApiManagementDiagnostic#data_masking}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataMasking", typeJson: "{\"fqn\":\"azurerm.apiManagementDiagnostic.ApiManagementDiagnosticFrontendRequestDataMasking\"}", isOptional: true)]
            public azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMasking? DataMasking
            {
                get => GetInstanceProperty<azurerm.ApiManagementDiagnostic.IApiManagementDiagnosticFrontendRequestDataMasking?>();
            }

            /// <summary>A list of headers to log.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_diagnostic#headers_to_log ApiManagementDiagnostic#headers_to_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headersToLog", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HeadersToLog
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
