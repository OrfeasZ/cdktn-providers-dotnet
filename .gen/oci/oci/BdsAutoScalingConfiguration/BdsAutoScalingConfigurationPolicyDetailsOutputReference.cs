using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsAutoScalingConfiguration
{
    [JsiiClass(nativeType: typeof(oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsOutputReference), fullyQualifiedName: "oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BdsAutoScalingConfigurationPolicyDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BdsAutoScalingConfigurationPolicyDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BdsAutoScalingConfigurationPolicyDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BdsAutoScalingConfigurationPolicyDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putScaleDownConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfig\"}}]")]
        public virtual void PutScaleDownConfig(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleInConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleInConfig\"}}]")]
        public virtual void PutScaleInConfig(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleInConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleInConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleOutConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfig\"}}]")]
        public virtual void PutScaleOutConfig(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScaleUpConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfig\"}}]")]
        public virtual void PutScaleUpConfig(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScheduleDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetails\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutScheduleDetails(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetails[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetails).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScheduleDetails).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetScaleDownConfig")]
        public virtual void ResetScaleDownConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleInConfig")]
        public virtual void ResetScaleInConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleOutConfig")]
        public virtual void ResetScaleOutConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleUpConfig")]
        public virtual void ResetScaleUpConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduleDetails")]
        public virtual void ResetScheduleDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimezone")]
        public virtual void ResetTimezone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scaleDownConfig", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference ScaleDownConfig
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfigOutputReference>()!;
        }

        [JsiiProperty(name: "scaleInConfig", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleInConfigOutputReference\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleInConfigOutputReference ScaleInConfig
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleInConfigOutputReference>()!;
        }

        [JsiiProperty(name: "scaleOutConfig", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigOutputReference\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigOutputReference ScaleOutConfig
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfigOutputReference>()!;
        }

        [JsiiProperty(name: "scaleUpConfig", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference ScaleUpConfig
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfigOutputReference>()!;
        }

        [JsiiProperty(name: "scheduleDetails", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsList\"}")]
        public virtual oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsList ScheduleDetails
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetailsList>()!;
        }

        [JsiiProperty(name: "triggerType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TriggerType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownConfigInput", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleDownConfig\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig? ScaleDownConfigInput
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleDownConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleInConfigInput", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleInConfig\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleInConfig? ScaleInConfigInput
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleInConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleOutConfigInput", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleOutConfig\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig? ScaleOutConfigInput
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleOutConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleUpConfigInput", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScaleUpConfig\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig? ScaleUpConfigInput
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetailsScaleUpConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleDetailsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetailsScheduleDetails\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ScheduleDetailsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.bdsAutoScalingConfiguration.BdsAutoScalingConfigurationPolicyDetails\"}", isOptional: true)]
        public virtual oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetails? InternalValue
        {
            get => GetInstanceProperty<oci.BdsAutoScalingConfiguration.IBdsAutoScalingConfigurationPolicyDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
