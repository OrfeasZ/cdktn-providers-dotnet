using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucket
{
    [JsiiInterface(nativeType: typeof(INetappVolumeBucketFileSystemNfsUser), fullyQualifiedName: "azurerm.netappVolumeBucket.NetappVolumeBucketFileSystemNfsUser")]
    public interface INetappVolumeBucketFileSystemNfsUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket#group_id NetappVolumeBucket#group_id}.</summary>
        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}")]
        double GroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket#user_id NetappVolumeBucket#user_id}.</summary>
        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"number\"}")]
        double UserId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetappVolumeBucketFileSystemNfsUser), fullyQualifiedName: "azurerm.netappVolumeBucket.NetappVolumeBucketFileSystemNfsUser")]
        internal sealed class _Proxy : DeputyBase, azurerm.NetappVolumeBucket.INetappVolumeBucketFileSystemNfsUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket#group_id NetappVolumeBucket#group_id}.</summary>
            [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}")]
            public double GroupId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.81.0/docs/resources/netapp_volume_bucket#user_id NetappVolumeBucket#user_id}.</summary>
            [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"number\"}")]
            public double UserId
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
