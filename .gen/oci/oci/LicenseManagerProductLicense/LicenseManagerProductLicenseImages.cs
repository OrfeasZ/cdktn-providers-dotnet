using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LicenseManagerProductLicense
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.licenseManagerProductLicense.LicenseManagerProductLicenseImages")]
    public class LicenseManagerProductLicenseImages : oci.LicenseManagerProductLicense.ILicenseManagerProductLicenseImages
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/license_manager_product_license#listing_id LicenseManagerProductLicense#listing_id}.</summary>
        [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
        public string ListingId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/license_manager_product_license#package_version LicenseManagerProductLicense#package_version}.</summary>
        [JsiiProperty(name: "packageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string PackageVersion
        {
            get;
            set;
        }
    }
}
