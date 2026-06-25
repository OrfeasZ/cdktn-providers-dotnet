using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FileStorageSnapshot
{
    [JsiiClass(nativeType: typeof(oci.FileStorageSnapshot.FileStorageSnapshotLockDurationDetailsOutputReference), fullyQualifiedName: "oci.fileStorageSnapshot.FileStorageSnapshotLockDurationDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FileStorageSnapshotLockDurationDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FileStorageSnapshotLockDurationDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FileStorageSnapshotLockDurationDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FileStorageSnapshotLockDurationDetailsOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fileStorageSnapshot.FileStorageSnapshotLockDurationDetails\"}", isOptional: true)]
        public virtual oci.FileStorageSnapshot.IFileStorageSnapshotLockDurationDetails? InternalValue
        {
            get => GetInstanceProperty<oci.FileStorageSnapshot.IFileStorageSnapshotLockDurationDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
