using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalAdminProduct
{
    [JsiiInterface(nativeType: typeof(IOciProductCatalogInternalAdminProductLimits), fullyQualifiedName: "oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductLimits")]
    public interface IOciProductCatalogInternalAdminProductLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#public_limit_name OciProductCatalogInternalAdminProduct#public_limit_name}.</summary>
        [JsiiProperty(name: "publicLimitName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicLimitName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#public_service_name OciProductCatalogInternalAdminProduct#public_service_name}.</summary>
        [JsiiProperty(name: "publicServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOciProductCatalogInternalAdminProductLimits), fullyQualifiedName: "oci.ociProductCatalogInternalAdminProduct.OciProductCatalogInternalAdminProductLimits")]
        internal sealed class _Proxy : DeputyBase, oci.OciProductCatalogInternalAdminProduct.IOciProductCatalogInternalAdminProductLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#public_limit_name OciProductCatalogInternalAdminProduct#public_limit_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicLimitName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicLimitName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_admin_product#public_service_name OciProductCatalogInternalAdminProduct#public_service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicServiceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
