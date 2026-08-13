using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SubscriptionSchedule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule stripe_subscription_schedule}.</summary>
    [JsiiClass(nativeType: typeof(stripe.SubscriptionSchedule.SubscriptionSchedule), fullyQualifiedName: "stripe.subscriptionSchedule.SubscriptionSchedule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleConfig\"}}]")]
    public class SubscriptionSchedule : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule stripe_subscription_schedule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SubscriptionSchedule(Constructs.Construct scope, string id, stripe.SubscriptionSchedule.ISubscriptionScheduleConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.SubscriptionSchedule.ISubscriptionScheduleConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionSchedule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubscriptionSchedule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a SubscriptionSchedule resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SubscriptionSchedule to import.</param>
        /// <param name="importFromId">The id of the existing SubscriptionSchedule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SubscriptionSchedule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SubscriptionSchedule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/subscription_schedule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SubscriptionSchedule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SubscriptionSchedule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.SubscriptionSchedule.SubscriptionSchedule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBillingMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleBillingMode\"}}]")]
        public virtual void PutBillingMode(stripe.SubscriptionSchedule.ISubscriptionScheduleBillingMode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SubscriptionSchedule.ISubscriptionScheduleBillingMode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettings\"}}]")]
        public virtual void PutDefaultSettings(stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettings)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhases" />)[]</param>
        [JsiiMethod(name: "putPhases", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhases\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPhases(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case stripe.SubscriptionSchedule.ISubscriptionSchedulePhases[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhases).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.SubscriptionSchedule.ISubscriptionSchedulePhases).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBillingMode")]
        public virtual void ResetBillingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomer")]
        public virtual void ResetCustomer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerAccount")]
        public virtual void ResetCustomerAccount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultSettings")]
        public virtual void ResetDefaultSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndBehavior")]
        public virtual void ResetEndBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFromSubscription")]
        public virtual void ResetFromSubscription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhases")]
        public virtual void ResetPhases()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartDate")]
        public virtual void ResetStartDate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.SubscriptionSchedule.SubscriptionSchedule))!;

        [JsiiProperty(name: "application", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Application
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "billingMode", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleBillingModeOutputReference\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionScheduleBillingModeOutputReference BillingMode
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionScheduleBillingModeOutputReference>()!;
        }

        [JsiiProperty(name: "canceledAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CanceledAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "completedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CompletedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currentPhase", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleCurrentPhaseOutputReference\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionScheduleCurrentPhaseOutputReference CurrentPhase
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionScheduleCurrentPhaseOutputReference>()!;
        }

        [JsiiProperty(name: "defaultSettings", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettingsOutputReference\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionScheduleDefaultSettingsOutputReference DefaultSettings
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionScheduleDefaultSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "phases", typeJson: "{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhasesList\"}")]
        public virtual stripe.SubscriptionSchedule.SubscriptionSchedulePhasesList Phases
        {
            get => GetInstanceProperty<stripe.SubscriptionSchedule.SubscriptionSchedulePhasesList>()!;
        }

        [JsiiProperty(name: "releasedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReleasedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "releasedSubscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleasedSubscription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subscription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "testClock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestClock
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionScheduleBillingMode" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingModeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleBillingMode\"}]}}", isOptional: true)]
        public virtual object? BillingModeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomerInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.SubscriptionSchedule.ISubscriptionScheduleDefaultSettings" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionScheduleDefaultSettings\"}]}}", isOptional: true)]
        public virtual object? DefaultSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fromSubscriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FromSubscriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.SubscriptionSchedule.ISubscriptionSchedulePhases" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phasesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.subscriptionSchedule.SubscriptionSchedulePhases\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PhasesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startDateInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StartDateInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "customer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Customer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customerAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerAccount
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fromSubscription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FromSubscription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startDate", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StartDate
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
