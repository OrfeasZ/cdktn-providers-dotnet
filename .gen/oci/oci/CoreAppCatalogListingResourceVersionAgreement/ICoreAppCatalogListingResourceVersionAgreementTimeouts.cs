using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreAppCatalogListingResourceVersionAgreement
{
    [JsiiInterface(nativeType: typeof(ICoreAppCatalogListingResourceVersionAgreementTimeouts), fullyQualifiedName: "oci.coreAppCatalogListingResourceVersionAgreement.CoreAppCatalogListingResourceVersionAgreementTimeouts")]
    public interface ICoreAppCatalogListingResourceVersionAgreementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_listing_resource_version_agreement#create CoreAppCatalogListingResourceVersionAgreement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_listing_resource_version_agreement#delete CoreAppCatalogListingResourceVersionAgreement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_listing_resource_version_agreement#update CoreAppCatalogListingResourceVersionAgreement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreAppCatalogListingResourceVersionAgreementTimeouts), fullyQualifiedName: "oci.coreAppCatalogListingResourceVersionAgreement.CoreAppCatalogListingResourceVersionAgreementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.CoreAppCatalogListingResourceVersionAgreement.ICoreAppCatalogListingResourceVersionAgreementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_listing_resource_version_agreement#create CoreAppCatalogListingResourceVersionAgreement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_listing_resource_version_agreement#delete CoreAppCatalogListingResourceVersionAgreement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_listing_resource_version_agreement#update CoreAppCatalogListingResourceVersionAgreement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
