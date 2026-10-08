using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOciProductCatalogProducts
{
    [JsiiInterface(nativeType: typeof(IDataOciOciProductCatalogProductsLimits), fullyQualifiedName: "oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimits")]
    public interface IDataOciOciProductCatalogProductsLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#public_limit_name DataOciOciProductCatalogProducts#public_limit_name}.</summary>
        [JsiiProperty(name: "publicLimitName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicLimitName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#public_service_name DataOciOciProductCatalogProducts#public_service_name}.</summary>
        [JsiiProperty(name: "publicServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciOciProductCatalogProductsLimits), fullyQualifiedName: "oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimits")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#public_limit_name DataOciOciProductCatalogProducts#public_limit_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicLimitName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicLimitName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#public_service_name DataOciOciProductCatalogProducts#public_service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicServiceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
