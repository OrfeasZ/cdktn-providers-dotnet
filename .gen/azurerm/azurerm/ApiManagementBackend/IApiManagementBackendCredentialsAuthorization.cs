using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendCredentialsAuthorization), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCredentialsAuthorization")]
    public interface IApiManagementBackendCredentialsAuthorization
    {
        /// <summary>The authentication Parameter value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#parameter ApiManagementBackend#parameter}
        /// </remarks>
        [JsiiProperty(name: "parameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Parameter
        {
            get
            {
                return null;
            }
        }

        /// <summary>The authentication Scheme name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#scheme ApiManagementBackend#scheme}
        /// </remarks>
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scheme
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendCredentialsAuthorization), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendCredentialsAuthorization")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendCredentialsAuthorization
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The authentication Parameter value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#parameter ApiManagementBackend#parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Parameter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The authentication Scheme name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#scheme ApiManagementBackend#scheme}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scheme
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
