using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementBackend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.apiManagementBackend.ApiManagementBackendServiceFabricClusterServerX509Name")]
    public class ApiManagementBackendServiceFabricClusterServerX509Name : azurerm.ApiManagementBackend.IApiManagementBackendServiceFabricClusterServerX509Name
    {
        /// <summary>The thumbprint for the issuer of the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#issuer_certificate_thumbprint ApiManagementBackend#issuer_certificate_thumbprint}
        /// </remarks>
        [JsiiProperty(name: "issuerCertificateThumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public string IssuerCertificateThumbprint
        {
            get;
            set;
        }

        /// <summary>The common name of the certificate.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_backend#name ApiManagementBackend#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
