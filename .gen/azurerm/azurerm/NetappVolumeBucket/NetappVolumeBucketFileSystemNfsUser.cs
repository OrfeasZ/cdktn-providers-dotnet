using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.netappVolumeBucket.NetappVolumeBucketFileSystemNfsUser")]
    public class NetappVolumeBucketFileSystemNfsUser : azurerm.NetappVolumeBucket.INetappVolumeBucketFileSystemNfsUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/netapp_volume_bucket#group_id NetappVolumeBucket#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}")]
        public double GroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.1/docs/resources/netapp_volume_bucket#user_id NetappVolumeBucket#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"number\"}")]
        public double UserId
        {
            get;
            set;
        }
    }
}
