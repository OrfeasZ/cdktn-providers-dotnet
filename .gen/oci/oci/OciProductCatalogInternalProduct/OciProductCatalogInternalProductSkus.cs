using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalProduct
{
    [JsiiByValue(fqn: "oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductSkus")]
    public class OciProductCatalogInternalProductSkus : oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#bpart_number OciProductCatalogInternalProduct#bpart_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "bpartNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BpartNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#description OciProductCatalogInternalProduct#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
