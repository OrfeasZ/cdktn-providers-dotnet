using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.PsqlDbSystem
{
    [JsiiClass(nativeType: typeof(oci.PsqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyOutputReference), fullyQualifiedName: "oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PsqlDbSystemManagementPolicyBackupPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PsqlDbSystemManagementPolicyBackupPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PsqlDbSystemManagementPolicyBackupPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PsqlDbSystemManagementPolicyBackupPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCopyPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyCopyPolicy\"}}]")]
        public virtual void PutCopyPolicy(oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicyCopyPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicyCopyPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackupStart")]
        public virtual void ResetBackupStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCopyPolicy")]
        public virtual void ResetCopyPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDaysOfTheMonth")]
        public virtual void ResetDaysOfTheMonth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDaysOfTheWeek")]
        public virtual void ResetDaysOfTheWeek()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKind")]
        public virtual void ResetKind()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionDays")]
        public virtual void ResetRetentionDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "copyPolicy", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyCopyPolicyOutputReference\"}")]
        public virtual oci.PsqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyCopyPolicyOutputReference CopyPolicy
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyCopyPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "copyPolicyInput", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicyCopyPolicy\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicyCopyPolicy? CopyPolicyInput
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicyCopyPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysOfTheMonthInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? DaysOfTheMonthInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysOfTheWeekInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DaysOfTheWeekInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kindInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KindInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "backupStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "daysOfTheMonth", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] DaysOfTheMonth
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "daysOfTheWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DaysOfTheWeek
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Kind
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retentionDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.psqlDbSystem.PsqlDbSystemManagementPolicyBackupPolicy\"}", isOptional: true)]
        public virtual oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.PsqlDbSystem.IPsqlDbSystemManagementPolicyBackupPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
