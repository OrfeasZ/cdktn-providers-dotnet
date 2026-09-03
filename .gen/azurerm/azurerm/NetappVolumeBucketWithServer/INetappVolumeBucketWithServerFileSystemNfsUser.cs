using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucketWithServer
{
    [JsiiInterface(nativeType: typeof(INetappVolumeBucketWithServerFileSystemNfsUser), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerFileSystemNfsUser")]
    public interface INetappVolumeBucketWithServerFileSystemNfsUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/netapp_volume_bucket_with_server#group_id NetappVolumeBucketWithServer#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}")]
        double GroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/netapp_volume_bucket_with_server#user_id NetappVolumeBucketWithServer#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"number\"}")]
        double UserId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeBucketWithServerFileSystemNfsUser), fullyQualifiedName: "azurerm.netappVolumeBucketWithServer.NetappVolumeBucketWithServerFileSystemNfsUser")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeBucketWithServer.INetappVolumeBucketWithServerFileSystemNfsUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/netapp_volume_bucket_with_server#group_id NetappVolumeBucketWithServer#group_id}.</summary>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}")]
            public double GroupId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/netapp_volume_bucket_with_server#user_id NetappVolumeBucketWithServer#user_id}.</summary>
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"number\"}")]
            public double UserId
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
