using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadDirectoryObject
{
    [JsiiByValue(fqn: "azuread.dataAzureadDirectoryObject.DataAzureadDirectoryObjectTimeouts")]
    public class DataAzureadDirectoryObjectTimeouts : azuread.DataAzureadDirectoryObject.IDataAzureadDirectoryObjectTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/directory_object#read DataAzureadDirectoryObject#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
