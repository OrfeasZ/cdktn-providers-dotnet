using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsTaskDefinition
{
    [JsiiClass(nativeType: typeof(aws.EcsTaskDefinition.EcsTaskDefinitionVolumeS3FilesVolumeConfigurationOutputReference), fullyQualifiedName: "aws.ecsTaskDefinition.EcsTaskDefinitionVolumeS3FilesVolumeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsTaskDefinitionVolumeS3FilesVolumeConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsTaskDefinitionVolumeS3FilesVolumeConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsTaskDefinitionVolumeS3FilesVolumeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeS3FilesVolumeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAccessPointArn")]
        public virtual void ResetAccessPointArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRootDirectory")]
        public virtual void ResetRootDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransitEncryptionPort")]
        public virtual void ResetTransitEncryptionPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessPointArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessPointArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitEncryptionPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TransitEncryptionPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "accessPointArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessPointArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileSystemArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDirectory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transitEncryptionPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TransitEncryptionPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsTaskDefinition.EcsTaskDefinitionVolumeS3FilesVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeS3FilesVolumeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EcsTaskDefinition.IEcsTaskDefinitionVolumeS3FilesVolumeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
