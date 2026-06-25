using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.CloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference), fullyQualifiedName: "oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudBridgeAssetAwsEc2NetworkInterfacesAttachmentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAttachmentKey")]
        public virtual void ResetAttachmentKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceIndex")]
        public virtual void ResetDeviceIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsDeleteOnTermination")]
        public virtual void ResetIsDeleteOnTermination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkCardIndex")]
        public virtual void ResetNetworkCardIndex()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeAttach")]
        public virtual void ResetTimeAttach()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "attachmentKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttachmentKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceIndexInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DeviceIndexInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isDeleteOnTerminationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsDeleteOnTerminationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkCardIndexInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NetworkCardIndexInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeAttachInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeAttachInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attachmentKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttachmentKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deviceIndex", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeviceIndex
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isDeleteOnTermination", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsDeleteOnTermination
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "networkCardIndex", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetworkCardIndex
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeAttach", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeAttach
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.cloudBridgeAsset.CloudBridgeAssetAwsEc2NetworkInterfacesAttachment\"}", isOptional: true)]
        public virtual oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment? InternalValue
        {
            get => GetInstanceProperty<oci.CloudBridgeAsset.ICloudBridgeAssetAwsEc2NetworkInterfacesAttachment?>();
            set => SetInstanceProperty(value);
        }
    }
}
