using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOciProductCatalogProducts
{
    [JsiiInterface(nativeType: typeof(IDataOciOciProductCatalogProductsMeters), fullyQualifiedName: "oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMeters")]
    public interface IDataOciOciProductCatalogProductsMeters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#name DataOciOciProductCatalogProducts#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciOciProductCatalogProductsMeters), fullyQualifiedName: "oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMeters")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#name DataOciOciProductCatalogProducts#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
