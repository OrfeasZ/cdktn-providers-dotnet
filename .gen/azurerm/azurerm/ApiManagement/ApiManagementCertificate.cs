using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagement.ApiManagementCertificate")]
    public class ApiManagementCertificate : azurerm.ApiManagement.IApiManagementCertificate
    {
        /// <summary>The Base64 Encoded PFX or Base64 Encoded X.509 Certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#encoded_certificate ApiManagement#encoded_certificate}
        /// </remarks>
        [JsiiProperty(name: "encodedCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public string EncodedCertificate
        {
            get;
            set;
        }

        /// <summary>The name of the Certificate Store where this certificate should be stored.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#store_name ApiManagement#store_name}
        /// </remarks>
        [JsiiProperty(name: "storeName", typeJson: "{\"primitive\":\"string\"}")]
        public string StoreName
        {
            get;
            set;
        }

        /// <summary>The password for the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management#certificate_password ApiManagement#certificate_password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificatePassword
        {
            get;
            set;
        }
    }
}
