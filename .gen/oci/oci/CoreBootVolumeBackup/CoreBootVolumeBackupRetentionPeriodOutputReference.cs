using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreBootVolumeBackup
{
    [JsiiClass(nativeType: typeof(oci.CoreBootVolumeBackup.CoreBootVolumeBackupRetentionPeriodOutputReference), fullyQualifiedName: "oci.coreBootVolumeBackup.CoreBootVolumeBackupRetentionPeriodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CoreBootVolumeBackupRetentionPeriodOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CoreBootVolumeBackupRetentionPeriodOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CoreBootVolumeBackupRetentionPeriodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CoreBootVolumeBackupRetentionPeriodOutputReference(DeputyProps props): base(props)
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.coreBootVolumeBackup.CoreBootVolumeBackupRetentionPeriod\"}", isOptional: true)]
        public virtual oci.CoreBootVolumeBackup.ICoreBootVolumeBackupRetentionPeriod? InternalValue
        {
            get => GetInstanceProperty<oci.CoreBootVolumeBackup.ICoreBootVolumeBackupRetentionPeriod?>();
            set => SetInstanceProperty(value);
        }
    }
}
