using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.DataAzureadApplicationPublishedAppIds
{
    [JsiiByValue(fqn: "azuread.dataAzureadApplicationPublishedAppIds.DataAzureadApplicationPublishedAppIdsTimeouts")]
    public class DataAzureadApplicationPublishedAppIdsTimeouts : azuread.DataAzureadApplicationPublishedAppIds.IDataAzureadApplicationPublishedAppIdsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/data-sources/application_published_app_ids#read DataAzureadApplicationPublishedAppIds#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
