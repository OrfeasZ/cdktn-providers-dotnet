using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadGroup
{
    [JsiiByValue(fqn: "azuread.dataAzureadGroup.DataAzureadGroupTimeouts")]
    public class DataAzureadGroupTimeouts : azuread.DataAzureadGroup.IDataAzureadGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/group#read DataAzureadGroup#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
