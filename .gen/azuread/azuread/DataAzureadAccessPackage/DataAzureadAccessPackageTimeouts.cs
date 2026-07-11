using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadAccessPackage
{
    [JsiiByValue(fqn: "azuread.dataAzureadAccessPackage.DataAzureadAccessPackageTimeouts")]
    public class DataAzureadAccessPackageTimeouts : azuread.DataAzureadAccessPackage.IDataAzureadAccessPackageTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/access_package#read DataAzureadAccessPackage#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
