using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOciProductCatalogProducts
{
    [JsiiByValue(fqn: "oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMeters")]
    public class DataOciOciProductCatalogProductsMeters : oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#name DataOciOciProductCatalogProducts#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
