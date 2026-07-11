using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadAccessPackageCatalog
{
    [JsiiByValue(fqn: "azuread.dataAzureadAccessPackageCatalog.DataAzureadAccessPackageCatalogTimeouts")]
    public class DataAzureadAccessPackageCatalogTimeouts : azuread.DataAzureadAccessPackageCatalog.IDataAzureadAccessPackageCatalogTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package_catalog#read DataAzureadAccessPackageCatalog#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
