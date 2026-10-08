using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalAdminProduct
{
    [JsiiInterface(nativeType: typeof(IOciProductCatalogInternalAdminProductMeters), fullyQualifiedName: "oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductMeters")]
    public interface IOciProductCatalogInternalAdminProductMeters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#name OciProductCatalogInternalAdminProduct#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOciProductCatalogInternalAdminProductMeters), fullyQualifiedName: "oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductMeters")]
        internal sealed class _Proxy : DeputyBase, oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductMeters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#name OciProductCatalogInternalAdminProduct#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
