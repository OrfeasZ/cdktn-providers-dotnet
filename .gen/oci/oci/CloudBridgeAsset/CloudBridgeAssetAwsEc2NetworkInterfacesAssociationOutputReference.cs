using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAssetAwsEc2NetworkInterfacesAssociationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCarrierIp")]
        public virtual void ResetCarrierIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerOwnedIp")]
        public virtual void ResetCustomerOwnedIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpOwnerKey")]
        public virtual void ResetIpOwnerKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicDnsName")]
        public virtual void ResetPublicDnsName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicIp")]
        public virtual void ResetPublicIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "carrierIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CarrierIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerOwnedIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerOwnedIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipOwnerKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpOwnerKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicDnsNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicDnsNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicIpInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PublicIpInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "carrierIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CarrierIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerOwnedIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerOwnedIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ipOwnerKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpOwnerKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicDnsName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicDnsName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicIp
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAssociation\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation? InternalValue
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAssociation?>();
            set => SetInstanceProperty(value);
        }
    }
}
