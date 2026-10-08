using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalProduct
{
    [JsiiInterface(nativeType: typeof(IOciProductCatalogInternalProductSkus), fullyQualifiedName: "oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductSkus")]
    public interface IOciProductCatalogInternalProductSkus
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#bpart_number OciProductCatalogInternalProduct#bpart_number}.</summary>
        [JsiiProperty(name: "bpartNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BpartNumber
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#description OciProductCatalogInternalProduct#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOciProductCatalogInternalProductSkus), fullyQualifiedName: "oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductSkus")]
        internal sealed class _Proxy : DeputyBase, oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#bpart_number OciProductCatalogInternalProduct#bpart_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "bpartNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BpartNumber
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#description OciProductCatalogInternalProduct#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
