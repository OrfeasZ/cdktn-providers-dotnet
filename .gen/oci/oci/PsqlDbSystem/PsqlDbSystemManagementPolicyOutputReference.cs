using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.PsqlDbSystem.PsqlDbSystemManagementPolicyOutputReference), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemManagementPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PsqlDbSystemManagementPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PsqlDbSystemManagementPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PsqlDbSystemManagementPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PsqlDbSystemManagementPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackupPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy\"}}]")]
        public virtual void PutBackupPolicy(oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackupPolicy")]
        public virtual void ResetBackupPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindowStart")]
        public virtual void ResetMaintenanceWindowStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyOutputReference BackupPolicy
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupPolicyInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy? BackupPolicyInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaintenanceWindowStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "maintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaintenanceWindowStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicy\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemManagementPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemManagementPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
