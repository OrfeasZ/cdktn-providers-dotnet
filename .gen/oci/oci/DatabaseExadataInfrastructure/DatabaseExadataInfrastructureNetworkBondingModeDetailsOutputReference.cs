using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    [JsiiClass(nativeType: typeof(oci.DatabaseExadataInfrastructure.DatabaseExadataInfrastructureNetworkBondingModeDetailsOutputReference), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureNetworkBondingModeDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseExadataInfrastructureNetworkBondingModeDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseExadataInfrastructureNetworkBondingModeDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseExadataInfrastructureNetworkBondingModeDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseExadataInfrastructureNetworkBondingModeDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBackupNetworkBondingMode")]
        public virtual void ResetBackupNetworkBondingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientNetworkBondingMode")]
        public virtual void ResetClientNetworkBondingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDrNetworkBondingMode")]
        public virtual void ResetDrNetworkBondingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupNetworkBondingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupNetworkBondingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientNetworkBondingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientNetworkBondingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "drNetworkBondingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DrNetworkBondingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backupNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "drNetworkBondingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DrNetworkBondingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureNetworkBondingModeDetails\"}", isOptional: true)]
        public virtual oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureNetworkBondingModeDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureNetworkBondingModeDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
