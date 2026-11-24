using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    [JsiiInterface(nativeType: typeof(IApiManagementCertificate), fullyQualifiedName: "azurerm.apiManagement.ApiManagementCertificate")]
    public interface IApiManagementCertificate
    {
        /// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#encoded_certificate ApiManagement#encoded_certificate}
        /// </remarks>
        [JsiiProperty(name: "encodedCertificate", typeJson: "{\"primitive\":\"string\"}")]
        string EncodedCertificate
        {
            get;
        }

        /// <summary>The name of the Certificate Store where this certificate should be stored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#store_name ApiManagement#store_name}
        /// </remarks>
        [JsiiProperty(name: "storeName", typeJson: "{\"primitive\":\"string\"}")]
        string StoreName
        {
            get;
        }

        /// <summary>The password for the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}
        /// </remarks>
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificatePassword
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementCertificate), fullyQualifiedName: "azurerm.apiManagement.ApiManagementCertificate")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagement.IApiManagementCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#encoded_certificate ApiManagement#encoded_certificate}
            /// </remarks>
            [JsiiProperty(name: "encodedCertificate", typeJson: "{\"primitive\":\"string\"}")]
            public string EncodedCertificate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the Certificate Store where this certificate should be stored.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#store_name ApiManagement#store_name}
            /// </remarks>
            [JsiiProperty(name: "storeName", typeJson: "{\"primitive\":\"string\"}")]
            public string StoreName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The password for the certificate.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificatePassword
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
