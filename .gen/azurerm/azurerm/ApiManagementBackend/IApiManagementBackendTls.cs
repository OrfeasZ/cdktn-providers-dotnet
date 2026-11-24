using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    [JsiiInterface(nativeType: typeof(IApiManagementBackendTls), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendTls")]
    public interface IApiManagementBackendTls
    {
        /// <summary>Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for the backend host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#validate_certificate_chain ApiManagementBackend#validate_certificate_chain}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "validateCertificateChain", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ValidateCertificateChain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for the backend host.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#validate_certificate_name ApiManagementBackend#validate_certificate_name}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "validateCertificateName", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ValidateCertificateName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementBackendTls), fullyQualifiedName: "azurerm.apiManagementBackend.ApiManagementBackendTls")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementBackend.IApiManagementBackendTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Flag indicating whether SSL certificate chain validation should be done when using self-signed certificates for the backend host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#validate_certificate_chain ApiManagementBackend#validate_certificate_chain}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validateCertificateChain", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ValidateCertificateChain
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Flag indicating whether SSL certificate name validation should be done when using self-signed certificates for the backend host.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#validate_certificate_name ApiManagementBackend#validate_certificate_name}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validateCertificateName", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ValidateCertificateName
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
