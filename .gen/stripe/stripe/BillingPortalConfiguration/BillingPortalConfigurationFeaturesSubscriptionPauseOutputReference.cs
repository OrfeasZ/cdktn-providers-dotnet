using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseOutputReference), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BillingPortalConfigurationFeaturesSubscriptionPauseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BillingPortalConfigurationFeaturesSubscriptionPauseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BillingPortalConfigurationFeaturesSubscriptionPauseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingPortalConfigurationFeaturesSubscriptionPauseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration\"}}]")]
        public virtual void PutDuration(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDuration")]
        public virtual void ResetDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "duration", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference Duration
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "durationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration\"}]}}", isOptional: true)]
        public virtual object? DurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object Enabled
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

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPause" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPause\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPause cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPause).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
