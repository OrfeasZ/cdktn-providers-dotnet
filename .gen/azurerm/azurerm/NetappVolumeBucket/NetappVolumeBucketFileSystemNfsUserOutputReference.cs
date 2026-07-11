using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappVolumeBucket
{
    [JsiiClass(nativeType: typeof(azurerm.NetappVolumeBucket.NetappVolumeBucketFileSystemNfsUserOutputReference), fullyQualifiedName: "azurerm.netappVolumeBucket.NetappVolumeBucketFileSystemNfsUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class NetappVolumeBucketFileSystemNfsUserOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public NetappVolumeBucketFileSystemNfsUserOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeBucketFileSystemNfsUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappVolumeBucketFileSystemNfsUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GroupIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userIdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UserIdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "groupId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GroupId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UserId
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.netappVolumeBucket.NetappVolumeBucketFileSystemNfsUser\"}", isOptional: true)]
        public virtual azurerm.NetappVolumeBucket.INetappVolumeBucketFileSystemNfsUser? InternalValue
        {
            get => GetInstanceProperty<azurerm.NetappVolumeBucket.INetappVolumeBucketFileSystemNfsUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
