using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LicenseManagerProductLicense
{
    [JsiiInterface(nativeType: typeof(ILicenseManagerProductLicenseImages), fullyQualifiedName: "oci.licenseManagerProductLicense.LicenseManagerProductLicenseImages")]
    public interface ILicenseManagerProductLicenseImages
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/license_manager_product_license#listing_id LicenseManagerProductLicense#listing_id}.</summary>
        [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
        string ListingId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/license_manager_product_license#package_version LicenseManagerProductLicense#package_version}.</summary>
        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        string PackageVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILicenseManagerProductLicenseImages), fullyQualifiedName: "oci.licenseManagerProductLicense.LicenseManagerProductLicenseImages")]
        internal sealed class _Proxy : DeputyBase, oci.LicenseManagerProductLicense.ILicenseManagerProductLicenseImages
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/license_manager_product_license#listing_id LicenseManagerProductLicense#listing_id}.</summary>
            [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
            public string ListingId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/license_manager_product_license#package_version LicenseManagerProductLicense#package_version}.</summary>
            [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string PackageVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
