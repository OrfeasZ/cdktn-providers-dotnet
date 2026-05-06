using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DisasterRecoveryDrProtectionGroup
{
    [JsiiClass(nativeType: typeof(oci.DisasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupConfigOutputReference), fullyQualifiedName: "oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DisasterRecoveryDrProtectionGroupMembersBackupConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DisasterRecoveryDrProtectionGroupMembersBackupConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DisasterRecoveryDrProtectionGroupMembersBackupConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DisasterRecoveryDrProtectionGroupMembersBackupConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBackupSchedule")]
        public virtual void ResetBackupSchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludeNamespaces")]
        public virtual void ResetExcludeNamespaces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageReplicationVaultSecretId")]
        public virtual void ResetImageReplicationVaultSecretId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxNumberOfBackupsRetained")]
        public virtual void ResetMaxNumberOfBackupsRetained()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamespaces")]
        public virtual void ResetNamespaces()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicateImages")]
        public virtual void ResetReplicateImages()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupScheduleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupScheduleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeNamespacesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludeNamespacesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageReplicationVaultSecretIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageReplicationVaultSecretIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxNumberOfBackupsRetainedInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxNumberOfBackupsRetainedInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namespacesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NamespacesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicateImagesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicateImagesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backupSchedule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupSchedule
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "excludeNamespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludeNamespaces
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "imageReplicationVaultSecretId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageReplicationVaultSecretId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxNumberOfBackupsRetained", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNumberOfBackupsRetained
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Namespaces
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicateImages", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicateImages
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.disasterRecoveryDrProtectionGroup.DisasterRecoveryDrProtectionGroupMembersBackupConfig\"}", isOptional: true)]
        public virtual oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DisasterRecoveryDrProtectionGroup.IDisasterRecoveryDrProtectionGroupMembersBackupConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
