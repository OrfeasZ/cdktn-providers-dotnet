using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ServiceCatalogServiceCatalogAssociation
{
    [JsiiByValue(fqn: "oci.serviceCatalogServiceCatalogAssociation.ServiceCatalogServiceCatalogAssociationTimeouts")]
    public class ServiceCatalogServiceCatalogAssociationTimeouts : oci.ServiceCatalogServiceCatalogAssociation.IServiceCatalogServiceCatalogAssociationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_service_catalog_association#create ServiceCatalogServiceCatalogAssociation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_service_catalog_association#delete ServiceCatalogServiceCatalogAssociation#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_service_catalog_association#update ServiceCatalogServiceCatalogAssociation#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
