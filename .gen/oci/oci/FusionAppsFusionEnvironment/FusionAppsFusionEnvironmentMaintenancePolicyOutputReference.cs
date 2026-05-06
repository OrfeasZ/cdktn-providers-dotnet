using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironment
{
    [JsiiClass(nativeType: typeof(oci.FusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicyOutputReference), fullyQualifiedName: "oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FusionAppsFusionEnvironmentMaintenancePolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FusionAppsFusionEnvironmentMaintenancePolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FusionAppsFusionEnvironmentMaintenancePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FusionAppsFusionEnvironmentMaintenancePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEnvironmentMaintenanceOverride")]
        public virtual void ResetEnvironmentMaintenanceOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthlyPatchingOverride")]
        public virtual void ResetMonthlyPatchingOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "quarterlyUpgradeBeginTimes", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicyQuarterlyUpgradeBeginTimesList\"}")]
        public virtual oci.FusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicyQuarterlyUpgradeBeginTimesList QuarterlyUpgradeBeginTimes
        {
            get => GetInstanceProperty<oci.FusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicyQuarterlyUpgradeBeginTimesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentMaintenanceOverrideInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentMaintenanceOverrideInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monthlyPatchingOverrideInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MonthlyPatchingOverrideInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "environmentMaintenanceOverride", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentMaintenanceOverride
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "monthlyPatchingOverride", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MonthlyPatchingOverride
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironment.FusionAppsFusionEnvironmentMaintenancePolicy\"}", isOptional: true)]
        public virtual oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentMaintenancePolicy? InternalValue
        {
            get => GetInstanceProperty<oci.FusionAppsFusionEnvironment.IFusionAppsFusionEnvironmentMaintenancePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
