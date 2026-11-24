using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SearchServiceDatasourceBlob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.searchServiceDatasourceBlob.SearchServiceDatasourceBlobEncryptionKey")]
    public class SearchServiceDatasourceBlobEncryptionKey : azurerm.SearchServiceDatasourceBlob.ISearchServiceDatasourceBlobEncryptionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#key_vault_key_id SearchServiceDatasourceBlob#key_vault_key_id}.</summary>
        [JsiiProperty(name: "keyVaultKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyVaultKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#client_id SearchServiceDatasourceBlob#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/search_service_datasource_blob#client_secret SearchServiceDatasourceBlob#client_secret}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientSecret
        {
            get;
            set;
        }
    }
}
