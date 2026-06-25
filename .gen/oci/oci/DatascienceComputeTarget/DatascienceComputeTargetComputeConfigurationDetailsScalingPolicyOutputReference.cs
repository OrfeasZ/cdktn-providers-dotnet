using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiClass(nativeType: typeof(oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference), fullyQualifiedName: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies" />)[]</param>
        [JsiiMethod(name: "putAutoScalingPolicies", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAutoScalingPolicies(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoScalingPolicies")]
        public virtual void ResetAutoScalingPolicies()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoolDownInSeconds")]
        public virtual void ResetCoolDownInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceCount")]
        public virtual void ResetInstanceCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIsEnabled")]
        public virtual void ResetIsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoScalingPolicies", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesList\"}")]
        public virtual oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesList AutoScalingPolicies
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPoliciesList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoScalingPoliciesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicyAutoScalingPolicies\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AutoScalingPoliciesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coolDownInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoolDownInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InstanceCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "coolDownInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoolDownInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InstanceCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object IsEnabled
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

        [JsiiProperty(name: "policyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsScalingPolicy\"}", isOptional: true)]
        public virtual oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy? InternalValue
        {
            get => GetInstanceProperty<oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsScalingPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
