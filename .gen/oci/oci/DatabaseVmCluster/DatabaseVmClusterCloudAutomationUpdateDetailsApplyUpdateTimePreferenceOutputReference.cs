using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmCluster
{
    [JsiiClass(nativeType: typeof(oci.DatabaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference), fullyQualifiedName: "oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetApplyUpdatePreferredEndTime")]
        public virtual void ResetApplyUpdatePreferredEndTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplyUpdatePreferredStartTime")]
        public virtual void ResetApplyUpdatePreferredStartTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyUpdatePreferredEndTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplyUpdatePreferredEndTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyUpdatePreferredStartTimeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApplyUpdatePreferredStartTimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "applyUpdatePreferredEndTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyUpdatePreferredEndTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applyUpdatePreferredStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApplyUpdatePreferredStartTime
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference\"}", isOptional: true)]
        public virtual oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference?>();
            set => SetInstanceProperty(value);
        }
    }
}
