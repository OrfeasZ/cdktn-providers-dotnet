using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudBridgeAsset.CloudBridgeAssetVmwareVcenterOutputReference), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudBridgeAssetVmwareVcenterOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudBridgeAssetVmwareVcenterOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudBridgeAssetVmwareVcenterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAssetVmwareVcenterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDataCenter")]
        public virtual void ResetDataCenter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcenterKey")]
        public virtual void ResetVcenterKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcenterVersion")]
        public virtual void ResetVcenterVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCenterInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataCenterInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcenterKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcenterKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcenterVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcenterVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataCenter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataCenter
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcenterKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcenterVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcenterVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetVmwareVcenter\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter? InternalValue
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetVmwareVcenter?>();
            set => SetInstanceProperty(value);
        }
    }
}
