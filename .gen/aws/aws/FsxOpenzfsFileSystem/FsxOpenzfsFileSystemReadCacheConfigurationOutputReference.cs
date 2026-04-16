using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FsxOpenzfsFileSystem
{
    [JsiiClass(nativeType: typeof(aws.FsxOpenzfsFileSystem.FsxOpenzfsFileSystemReadCacheConfigurationOutputReference), fullyQualifiedName: "aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemReadCacheConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FsxOpenzfsFileSystemReadCacheConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FsxOpenzfsFileSystemReadCacheConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FsxOpenzfsFileSystemReadCacheConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsFileSystemReadCacheConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSize")]
        public virtual void ResetSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSizingMode")]
        public virtual void ResetSizingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SizingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Size
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SizingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsxOpenzfsFileSystem.FsxOpenzfsFileSystemReadCacheConfiguration\"}", isOptional: true)]
        public virtual aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemReadCacheConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.FsxOpenzfsFileSystem.IFsxOpenzfsFileSystemReadCacheConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
