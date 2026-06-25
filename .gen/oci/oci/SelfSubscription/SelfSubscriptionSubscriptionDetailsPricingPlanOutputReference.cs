using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.SelfSubscription
{
    [JsiiClass(nativeType: typeof(oci.SelfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference), fullyQualifiedName: "oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SelfSubscriptionSubscriptionDetailsPricingPlanOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates" />)[]</param>
        [JsiiMethod(name: "putRates", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRates\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRates(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPlanDescription")]
        public virtual void ResetPlanDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlanDuration")]
        public virtual void ResetPlanDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rates", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRatesList\"}")]
        public virtual oci.SelfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRatesList Rates
        {
            get => GetInstanceProperty<oci.SelfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRatesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "billingFrequencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BillingFrequencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planDurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanDurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlanTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlanRates" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ratesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlanRates\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RatesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "billingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingFrequency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "planDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "planDuration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanDuration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "planName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "planType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlanType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.selfSubscription.SelfSubscriptionSubscriptionDetailsPricingPlan\"}", isOptional: true)]
        public virtual oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan? InternalValue
        {
            get => GetInstanceProperty<oci.SelfSubscription.ISelfSubscriptionSubscriptionDetailsPricingPlan?>();
            set => SetInstanceProperty(value);
        }
    }
}
