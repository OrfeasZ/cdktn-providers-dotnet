using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageFilesystemSnapshotPolicy
{
    [JsiiClass(nativeType: typeof(oci.FileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetailsOutputReference), fullyQualifiedName: "oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCoolOffDuration")]
        public virtual void ResetCoolOffDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "coolOffDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoolOffDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lockDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LockDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lockModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LockModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "coolOffDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoolOffDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LockDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lockMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LockMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fileStorageFilesystemSnapshotPolicy.FileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails\"}", isOptional: true)]
        public virtual oci.FileStorageFilesystemSnapshotPolicy.IFileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.FileStorageFilesystemSnapshotPolicy.IFileStorageFilesystemSnapshotPolicySchedulesLockDurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
