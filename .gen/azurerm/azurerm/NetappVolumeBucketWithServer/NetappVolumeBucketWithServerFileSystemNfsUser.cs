using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerFileSystemNfsUser")]
    public class NetappVolumeBucketWithServerFileSystemNfsUser : azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerFileSystemNfsUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_bucket_with_server#group_id NetappVolumeBucketWithServer#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}")]
        public double GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/netapp_volume_bucket_with_server#user_id NetappVolumeBucketWithServer#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"number\"}")]
        public double UserId
        {
            get;
            set;
        }
    }
}
