using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadServicePrincipals
{
    [JsiiByValue(fqn: "azuread.dataAzureadServicePrincipals.DataAzureadServicePrincipalsTimeouts")]
    public class DataAzureadServicePrincipalsTimeouts : azuread.DataAzureadServicePrincipals.IDataAzureadServicePrincipalsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/service_principals#read DataAzureadServicePrincipals#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
