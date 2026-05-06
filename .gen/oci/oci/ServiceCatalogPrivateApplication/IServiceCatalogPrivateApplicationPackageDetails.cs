using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ServiceCatalogPrivateApplication
{
    [JsiiInterface(nativeType: typeof(IServiceCatalogPrivateApplicationPackageDetails), fullyQualifiedName: "oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationPackageDetails")]
    public interface IServiceCatalogPrivateApplicationPackageDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#package_type ServiceCatalogPrivateApplication#package_type}.</summary>
        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        string PackageType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#version ServiceCatalogPrivateApplication#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#zip_file_base64encoded ServiceCatalogPrivateApplication#zip_file_base64encoded}.</summary>
        [JsiiProperty(name: "zipFileBase64Encoded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZipFileBase64Encoded
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceCatalogPrivateApplicationPackageDetails), fullyQualifiedName: "oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationPackageDetails")]
        internal sealed class _Proxy : DeputyBase, oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationPackageDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#package_type ServiceCatalogPrivateApplication#package_type}.</summary>
            [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
            public string PackageType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#version ServiceCatalogPrivateApplication#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#zip_file_base64encoded ServiceCatalogPrivateApplication#zip_file_base64encoded}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zipFileBase64Encoded", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZipFileBase64Encoded
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
