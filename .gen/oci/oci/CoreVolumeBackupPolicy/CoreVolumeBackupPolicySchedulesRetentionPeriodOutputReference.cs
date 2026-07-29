using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreVolumeBackupPolicy
{
    [JsiiClass(nativeType: typeof(oci.CoreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriodOutputReference), fullyQualifiedName: "oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreVolumeBackupPolicySchedulesRetentionPeriodOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreVolumeBackupPolicySchedulesRetentionPeriodOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreVolumeBackupPolicySchedulesRetentionPeriodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreVolumeBackupPolicySchedulesRetentionPeriodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionTimeAmountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionTimeAmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionTimeUnitInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RetentionTimeUnitInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "retentionTimeAmount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionTimeAmount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retentionTimeUnit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetentionTimeUnit
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreVolumeBackupPolicy.CoreVolumeBackupPolicySchedulesRetentionPeriod\"}", isOptional: true)]
        public virtual oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedulesRetentionPeriod? InternalValue
        {
            get => GetInstanceProperty<oci.CoreVolumeBackupPolicy.ICoreVolumeBackupPolicySchedulesRetentionPeriod?>();
            set => SetInstanceProperty(value);
        }
    }
}
