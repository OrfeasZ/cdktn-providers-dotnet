using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurestack.Image
{
    [JsiiClass(nativeType: typeof(azurestack.Image.ImageOsDiskOutputReference), fullyQualifiedName: "azurestack.image.ImageOsDiskOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ImageOsDiskOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ImageOsDiskOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ImageOsDiskOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImageOsDiskOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBlobUri")]
        public virtual void ResetBlobUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCaching")]
        public virtual void ResetCaching()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedDiskId")]
        public virtual void ResetManagedDiskId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsState")]
        public virtual void ResetOsState()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOsType")]
        public virtual void ResetOsType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSizeGb")]
        public virtual void ResetSizeGb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "blobUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BlobUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cachingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CachingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedDiskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ManagedDiskIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osStateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsStateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "osTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OsTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeGbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeGbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "blobUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BlobUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "caching", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Caching
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "managedDiskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ManagedDiskId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "osState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsState
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizeGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SizeGb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurestack.image.ImageOsDisk\"}", isOptional: true)]
        public virtual azurestack.Image.IImageOsDisk? InternalValue
        {
            get => GetInstanceProperty<azurestack.Image.IImageOsDisk?>();
            set => SetInstanceProperty(value);
        }
    }
}
