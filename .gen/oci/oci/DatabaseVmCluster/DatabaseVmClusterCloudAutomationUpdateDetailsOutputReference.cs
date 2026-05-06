using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseVmCluster
{
    [JsiiClass(nativeType: typeof(oci.DatabaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsOutputReference), fullyQualifiedName: "oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseVmClusterCloudAutomationUpdateDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseVmClusterCloudAutomationUpdateDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseVmClusterCloudAutomationUpdateDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseVmClusterCloudAutomationUpdateDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplyUpdateTimePreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference\"}}]")]
        public virtual void PutApplyUpdateTimePreference(oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFreezePeriod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod\"}}]")]
        public virtual void PutFreezePeriod(oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplyUpdateTimePreference")]
        public virtual void ResetApplyUpdateTimePreference()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreezePeriod")]
        public virtual void ResetFreezePeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsEarlyAdoptionEnabled")]
        public virtual void ResetIsEarlyAdoptionEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsFreezePeriodEnabled")]
        public virtual void ResetIsFreezePeriodEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applyUpdateTimePreference", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference\"}")]
        public virtual oci.DatabaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference ApplyUpdateTimePreference
        {
            get => GetInstanceProperty<oci.DatabaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference>()!;
        }

        [JsiiProperty(name: "freezePeriod", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference\"}")]
        public virtual oci.DatabaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference FreezePeriod
        {
            get => GetInstanceProperty<oci.DatabaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyUpdateTimePreferenceInput", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference\"}", isOptional: true)]
        public virtual oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference? ApplyUpdateTimePreferenceInput
        {
            get => GetInstanceProperty<oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freezePeriodInput", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod\"}", isOptional: true)]
        public virtual oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod? FreezePeriodInput
        {
            get => GetInstanceProperty<oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetailsFreezePeriod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isEarlyAdoptionEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEarlyAdoptionEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "isFreezePeriodEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsFreezePeriodEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "isEarlyAdoptionEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEarlyAdoptionEnabled
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

        [JsiiProperty(name: "isFreezePeriodEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsFreezePeriodEnabled
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseVmCluster.DatabaseVmClusterCloudAutomationUpdateDetails\"}", isOptional: true)]
        public virtual oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseVmCluster.IDatabaseVmClusterCloudAutomationUpdateDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
