using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VideoIndexerAccount
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.videoIndexerAccount.VideoIndexerAccountStorage")]
    public class VideoIndexerAccountStorage : azurerm.VideoIndexerAccount.IVideoIndexerAccountStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/video_indexer_account#storage_account_id VideoIndexerAccount#storage_account_id}.</summary>
        [JsiiProperty(name: "storageAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageAccountId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/video_indexer_account#user_assigned_identity_id VideoIndexerAccount#user_assigned_identity_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userAssignedIdentityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAssignedIdentityId
        {
            get;
            set;
        }
    }
}
