using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementPayoutIntent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent stripe_v2_money_management_payout_intent}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntent), fullyQualifiedName: "stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentConfig\"}}]")]
    public class V2MoneyManagementPayoutIntent : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent stripe_v2_money_management_payout_intent} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2MoneyManagementPayoutIntent(Constructs.Construct scope, string id, stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementPayoutIntent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementPayoutIntent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2MoneyManagementPayoutIntent resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2MoneyManagementPayoutIntent to import.</param>
        /// <param name="importFromId">The id of the existing V2MoneyManagementPayoutIntent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2MoneyManagementPayoutIntent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2MoneyManagementPayoutIntent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_payout_intent#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2MoneyManagementPayoutIntent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2MoneyManagementPayoutIntent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAmount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentAmount\"}}]")]
        public virtual void PutAmount(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentAmount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentAmount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrom", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFrom\"}}]")]
        public virtual void PutFrom(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFrom @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFrom)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecipientNotification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotification\"}}]")]
        public virtual void PutRecipientNotification(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientNotification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientNotification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScheduleOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptions\"}}]")]
        public virtual void PutScheduleOptions(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentScheduleOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentScheduleOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentTo\"}}]")]
        public virtual void PutTo(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentTo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentTo)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfirmationMethod")]
        public virtual void ResetConfirmationMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecipientNotification")]
        public virtual void ResetRecipientNotification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScheduleOptions")]
        public virtual void ResetScheduleOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatementDescriptor")]
        public virtual void ResetStatementDescriptor()
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
        = GetStaticProperty<string>(typeof(stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntent))!;

        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentAmountOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentAmountOutputReference Amount
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentAmountOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedFees", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesList\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesList EstimatedFees
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentEstimatedFeesList>()!;
        }

        [JsiiProperty(name: "from", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFromOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFromOutputReference From
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFromOutputReference>()!;
        }

        [JsiiProperty(name: "fxQuote", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuoteOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuoteOutputReference FxQuote
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFxQuoteOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "latestPayout", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentLatestPayoutOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentLatestPayoutOutputReference LatestPayout
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentLatestPayoutOutputReference>()!;
        }

        [JsiiProperty(name: "livemode", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Livemode
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "nextAction", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentNextActionOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentNextActionOutputReference NextAction
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentNextActionOutputReference>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recipientNotification", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotificationOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotificationOutputReference RecipientNotification
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotificationOutputReference>()!;
        }

        [JsiiProperty(name: "recipientVerification", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientVerificationOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientVerificationOutputReference RecipientVerification
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientVerificationOutputReference>()!;
        }

        [JsiiProperty(name: "scheduleOptions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptionsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptionsOutputReference ScheduleOptions
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusTransitions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentStatusTransitionsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentStatusTransitionsOutputReference StatusTransitions
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentStatusTransitionsOutputReference>()!;
        }

        [JsiiProperty(name: "to", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToOutputReference\"}")]
        public virtual stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToOutputReference To
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentToOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentAmount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentAmount\"}]}}", isOptional: true)]
        public virtual object? AmountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "confirmationMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfirmationMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentFrom" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fromInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentFrom\"}]}}", isOptional: true)]
        public virtual object? FromInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentRecipientNotification" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recipientNotificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentRecipientNotification\"}]}}", isOptional: true)]
        public virtual object? RecipientNotificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentScheduleOptions" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheduleOptionsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentScheduleOptions\"}]}}", isOptional: true)]
        public virtual object? ScheduleOptionsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatementDescriptorInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementPayoutIntent.IV2MoneyManagementPayoutIntentTo" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "toInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementPayoutIntent.V2MoneyManagementPayoutIntentTo\"}]}}", isOptional: true)]
        public virtual object? ToInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "confirmationMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfirmationMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "statementDescriptor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatementDescriptor
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
