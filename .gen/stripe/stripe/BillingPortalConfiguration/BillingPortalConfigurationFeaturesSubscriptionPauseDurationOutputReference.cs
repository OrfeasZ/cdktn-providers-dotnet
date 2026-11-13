using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiClass(nativeType: typeof(stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingPortalConfigurationFeaturesSubscriptionPauseDurationOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions" />)[]</param>
        [JsiiMethod(name: "putIntervalOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIntervalOptions(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIntervalOptions")]
        public virtual void ResetIntervalOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "intervalOptions", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptionsList\"}")]
        public virtual stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptionsList IntervalOptions
        {
            get => GetInstanceProperty<stripe.BillingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptionsList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "intervalOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDurationIntervalOptions\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IntervalOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionPauseDuration\"}]}}", isOptional: true)]
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
                        case stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionPauseDuration).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
