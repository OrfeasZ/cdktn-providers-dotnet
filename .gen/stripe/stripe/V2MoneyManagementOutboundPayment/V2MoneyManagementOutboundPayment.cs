using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundPayment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment stripe_v2_money_management_outbound_payment}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPayment), fullyQualifiedName: "stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPayment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentConfig\"}}]")]
    public class V2MoneyManagementOutboundPayment : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment stripe_v2_money_management_outbound_payment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2MoneyManagementOutboundPayment(Constructs.Construct scope, string id, stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementOutboundPayment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementOutboundPayment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2MoneyManagementOutboundPayment resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2MoneyManagementOutboundPayment to import.</param>
        /// <param name="importFromId">The id of the existing V2MoneyManagementOutboundPayment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2MoneyManagementOutboundPayment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2MoneyManagementOutboundPayment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_payment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2MoneyManagementOutboundPayment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2MoneyManagementOutboundPayment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPayment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAmount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentAmount\"}}]")]
        public virtual void PutAmount(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentAmount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentAmount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFrom", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFrom\"}}]")]
        public virtual void PutFrom(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentFrom @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentFrom)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRecipientNotification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentRecipientNotification\"}}]")]
        public virtual void PutRecipientNotification(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentRecipientNotification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentRecipientNotification)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTo", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTo\"}}]")]
        public virtual void PutTo(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentTo @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentTo)}, new object[]{@value});
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

        [JsiiMethod(name: "resetRecipientVerification")]
        public virtual void ResetRecipientVerification()
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
        = GetStaticProperty<string>(typeof(stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPayment))!;

        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentAmountOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentAmountOutputReference Amount
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentAmountOutputReference>()!;
        }

        [JsiiProperty(name: "cancelable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Cancelable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expectedArrivalDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpectedArrivalDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "from", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFromOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFromOutputReference From
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFromOutputReference>()!;
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

        [JsiiProperty(name: "payoutIntent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayoutIntent
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "recipientNotification", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentRecipientNotificationOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentRecipientNotificationOutputReference RecipientNotification
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentRecipientNotificationOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusDetails", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsOutputReference StatusDetails
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "statusTransitions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusTransitionsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusTransitionsOutputReference StatusTransitions
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentStatusTransitionsOutputReference>()!;
        }

        [JsiiProperty(name: "to", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToOutputReference To
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentToOutputReference>()!;
        }

        [JsiiProperty(name: "trackingDetails", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTrackingDetailsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTrackingDetailsOutputReference TrackingDetails
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTrackingDetailsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentAmount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentAmount\"}]}}", isOptional: true)]
        public virtual object? AmountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentFrom" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fromInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentFrom\"}]}}", isOptional: true)]
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
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentRecipientNotification" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recipientNotificationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentRecipientNotification\"}]}}", isOptional: true)]
        public virtual object? RecipientNotificationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recipientVerificationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecipientVerificationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statementDescriptorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatementDescriptorInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundPayment.IV2MoneyManagementOutboundPaymentTo" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "toInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundPayment.V2MoneyManagementOutboundPaymentTo\"}]}}", isOptional: true)]
        public virtual object? ToInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "recipientVerification", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecipientVerification
        {
            get => GetInstanceProperty<string>()!;
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
