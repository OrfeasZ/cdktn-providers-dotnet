using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg
{
    [JsiiClass(nativeType: typeof(oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference), fullyQualifiedName: "oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabaseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCloudAutonomousVmClusterId")]
        public virtual void ResetCloudAutonomousVmClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFastStartFailOverLagLimitInSeconds")]
        public virtual void ResetFastStartFailOverLagLimitInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtectionMode")]
        public virtual void ResetProtectionMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStandbyMaintenanceBufferInDays")]
        public virtual void ResetStandbyMaintenanceBufferInDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudAutonomousVmClusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudAutonomousVmClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fastStartFailOverLagLimitInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? FastStartFailOverLagLimitInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "protectionModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtectionModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "standbyMaintenanceBufferInDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StandbyMaintenanceBufferInDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cloudAutonomousVmClusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudAutonomousVmClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fastStartFailOverLagLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FastStartFailOverLagLimitInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "protectionMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProtectionMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "standbyMaintenanceBufferInDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StandbyMaintenanceBufferInDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.distributedDatabaseDistributedAutonomousDatabasesInsertDg.DistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase\"}", isOptional: true)]
        public virtual oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase? InternalValue
        {
            get => GetInstanceProperty<oci.DistributedDatabaseDistributedAutonomousDatabasesInsertDg.IDistributedDatabaseDistributedAutonomousDatabasesInsertDgInsertDgDatabase?>();
            set => SetInstanceProperty(value);
        }
    }
}
