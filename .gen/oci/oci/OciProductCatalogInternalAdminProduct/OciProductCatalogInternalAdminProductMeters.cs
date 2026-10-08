using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalAdminProduct
{
    [JsiiByValue(fqn: "oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductMeters")]
    public class OciProductCatalogInternalAdminProductMeters : oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductMeters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#name OciProductCatalogInternalAdminProduct#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
