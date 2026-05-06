using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FusionAppsFusionEnvironmentFamily
{
    [JsiiClass(nativeType: typeof(oci.FusionAppsFusionEnvironmentFamily.FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicyOutputReference), fullyQualifiedName: "oci.fusionAppsFusionEnvironmentFamily.FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConcurrentMaintenance")]
        public virtual void ResetConcurrentMaintenance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsMonthlyPatchingEnabled")]
        public virtual void ResetIsMonthlyPatchingEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQuarterlyUpgradeBeginTimes")]
        public virtual void ResetQuarterlyUpgradeBeginTimes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "concurrentMaintenanceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConcurrentMaintenanceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isMonthlyPatchingEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsMonthlyPatchingEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "quarterlyUpgradeBeginTimesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? QuarterlyUpgradeBeginTimesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "concurrentMaintenance", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConcurrentMaintenance
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "isMonthlyPatchingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsMonthlyPatchingEnabled
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "quarterlyUpgradeBeginTimes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuarterlyUpgradeBeginTimes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.fusionAppsFusionEnvironmentFamily.FusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy\"}", isOptional: true)]
        public virtual oci.FusionAppsFusionEnvironmentFamily.IFusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy? InternalValue
        {
            get => GetInstanceProperty<oci.FusionAppsFusionEnvironmentFamily.IFusionAppsFusionEnvironmentFamilyFamilyMaintenancePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
