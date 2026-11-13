using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    [JsiiClass(nativeType: typeof(stripe.SubscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsOutputReference), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SubscriptionSchedulePhasesInvoiceSettingsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SubscriptionSchedulePhasesInvoiceSettingsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SubscriptionSchedulePhasesInvoiceSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionSchedulePhasesInvoiceSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettingsCustomFields" />)[]</param>
        [JsiiMethod(name: "putCustomFields", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsCustomFields\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomFields(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettingsCustomFields[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettingsCustomFields).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettingsCustomFields).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIssuer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsIssuer\"}}]")]
        public virtual void PutIssuer(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettingsIssuer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettingsIssuer)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountTaxIds")]
        public virtual void ResetAccountTaxIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomFields")]
        public virtual void ResetCustomFields()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDaysUntilDue")]
        public virtual void ResetDaysUntilDue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFooter")]
        public virtual void ResetFooter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuer")]
        public virtual void ResetIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customFields", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsCustomFieldsList\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsCustomFieldsList CustomFields
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsCustomFieldsList>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsIssuerOutputReference\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsIssuerOutputReference Issuer
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsIssuerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountTaxIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AccountTaxIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettingsCustomFields" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customFieldsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsCustomFields\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFieldsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "daysUntilDueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DaysUntilDueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "footerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FooterInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettingsIssuer" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettingsIssuer\"}]}}", isOptional: true)]
        public virtual object? IssuerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "accountTaxIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AccountTaxIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "daysUntilDue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DaysUntilDue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "footer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Footer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesInvoiceSettings\"}]}}", isOptional: true)]
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
                        case stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettings cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhasesInvoiceSettings).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
