using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadUser
{
    [JsiiByValue(fqn: "azuread.dataAzureadUser.DataAzureadUserTimeouts")]
    public class DataAzureadUserTimeouts : azuread.DataAzureadUser.IDataAzureadUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/user#read DataAzureadUser#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
