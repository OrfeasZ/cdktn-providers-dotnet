using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadAccessPackageCatalogRole
{
    [JsiiByValue(fqn: "azuread.dataAzureadAccessPackageCatalogRole.DataAzureadAccessPackageCatalogRoleTimeouts")]
    public class DataAzureadAccessPackageCatalogRoleTimeouts : azuread.DataAzureadAccessPackageCatalogRole.IDataAzureadAccessPackageCatalogRoleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package_catalog_role#read DataAzureadAccessPackageCatalogRole#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
