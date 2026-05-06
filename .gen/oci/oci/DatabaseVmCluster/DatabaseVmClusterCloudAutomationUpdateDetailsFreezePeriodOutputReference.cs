using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmCluster
{
    [JsiiClass(nativeType: typeof(oci.DatabaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference), fullyQualifiedName: "oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFreezePeriodEndTime")]
        public virtual void ResetFreezePeriodEndTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreezePeriodStartTime")]
        public virtual void ResetFreezePeriodStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "freezePeriodEndTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FreezePeriodEndTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freezePeriodStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FreezePeriodStartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "freezePeriodEndTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FreezePeriodEndTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freezePeriodStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FreezePeriodStartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod\"}", isOptional: true)]
        public virtual oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod?>();
            set => SetInstanceProperty(value);
        }
    }
}
