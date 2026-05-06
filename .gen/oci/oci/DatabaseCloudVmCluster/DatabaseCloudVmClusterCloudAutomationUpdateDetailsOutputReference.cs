using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseCloudVmCluster
{
    [JsiiClass(nativeType: typeof(oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference), fullyQualifiedName: "oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatabaseCloudVmClusterCloudAutomationUpdateDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplyUpdateTimePreference", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference\"}}]")]
        public virtual void PutApplyUpdateTimePreference(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFreezePeriod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod\"}}]")]
        public virtual void PutFreezePeriod(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod)}, new object[]{@value});
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

        [JsiiProperty(name: "applyUpdateTimePreference", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference\"}")]
        public virtual oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference ApplyUpdateTimePreference
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreferenceOutputReference>()!;
        }

        [JsiiProperty(name: "freezePeriod", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference\"}")]
        public virtual oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference FreezePeriod
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriodOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applyUpdateTimePreferenceInput", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference\"}", isOptional: true)]
        public virtual oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference? ApplyUpdateTimePreferenceInput
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsApplyUpdateTimePreference?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freezePeriodInput", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod\"}", isOptional: true)]
        public virtual oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod? FreezePeriodInput
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetailsFreezePeriod?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.databaseCloudVmCluster.DatabaseCloudVmClusterCloudAutomationUpdateDetails\"}", isOptional: true)]
        public virtual oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DatabaseCloudVmCluster.IDatabaseCloudVmClusterCloudAutomationUpdateDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
