using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalAdminProduct
{
    [JsiiByValue(fqn: "oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductSkus")]
    public class OciProductCatalogInternalAdminProductSkus : oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductSkus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#bpart_number OciProductCatalogInternalAdminProduct#bpart_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bpartNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BpartNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#description OciProductCatalogInternalAdminProduct#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
