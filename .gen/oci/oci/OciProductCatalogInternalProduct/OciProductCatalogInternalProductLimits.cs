using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalProduct
{
    [JsiiByValue(fqn: "oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductLimits")]
    public class OciProductCatalogInternalProductLimits : oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#public_limit_name OciProductCatalogInternalProduct#public_limit_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicLimitName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicLimitName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#public_service_name OciProductCatalogInternalProduct#public_service_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PublicServiceName
        {
            get;
            set;
        }
    }
}
