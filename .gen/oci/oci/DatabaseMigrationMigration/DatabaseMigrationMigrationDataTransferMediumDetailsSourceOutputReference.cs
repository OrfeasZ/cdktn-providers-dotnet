using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseMigrationMigration
{
    [JsiiClass(nativeType: typeof(oci.DatabaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference), fullyQualifiedName: "oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseMigrationMigrationDataTransferMediumDetailsSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetOciHome")]
        public virtual void ResetOciHome()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWalletLocation")]
        public virtual void ResetWalletLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ociHomeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OciHomeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "walletLocationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WalletLocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ociHome", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OciHome
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "walletLocation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WalletLocation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseMigrationMigration.DatabaseMigrationMigrationDataTransferMediumDetailsSource\"}", isOptional: true)]
        public virtual oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseMigrationMigration.IDatabaseMigrationMigrationDataTransferMediumDetailsSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
