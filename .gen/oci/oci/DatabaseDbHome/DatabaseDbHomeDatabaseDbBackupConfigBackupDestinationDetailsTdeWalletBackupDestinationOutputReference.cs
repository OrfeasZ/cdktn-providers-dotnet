using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDbHome
{
    [JsiiClass(nativeType: typeof(oci.DatabaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestinationOutputReference), fullyQualifiedName: "oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestinationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestinationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestinationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestinationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestinationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBackupDestinationId")]
        public virtual void ResetBackupDestinationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupDestinationType")]
        public virtual void ResetBackupDestinationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupDestinationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupDestinationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupDestinationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backupDestinationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupDestinationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupDestinationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupDestinationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseDbHome.DatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination\"}", isOptional: true)]
        public virtual oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseDbHome.IDatabaseDbHomeDatabaseDbBackupConfigBackupDestinationDetailsTdeWalletBackupDestination?>();
            set => SetInstanceProperty(value);
        }
    }
}
