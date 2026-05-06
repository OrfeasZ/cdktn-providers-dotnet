using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ServiceCatalogPrivateApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationPackageDetails")]
    public class ServiceCatalogPrivateApplicationPackageDetails : oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationPackageDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#package_type ServiceCatalogPrivateApplication#package_type}.</summary>
        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public string PackageType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#version ServiceCatalogPrivateApplication#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#zip_file_base64encoded ServiceCatalogPrivateApplication#zip_file_base64encoded}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zipFileBase64Encoded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ZipFileBase64Encoded
        {
            get;
            set;
        }
    }
}
