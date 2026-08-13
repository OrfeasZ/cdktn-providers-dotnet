using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingCreditGrant
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant stripe_billing_credit_grant}.</summary>
    [JsiiClass(nativeType: typeof(stripe.BillingCreditGrant.BillingCreditGrant), fullyQualifiedName: "stripe.billingCreditGrant.BillingCreditGrant", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantConfig\"}}]")]
    public class BillingCreditGrant : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant stripe_billing_credit_grant} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BillingCreditGrant(Constructs.Construct scope, string id, stripe.BillingCreditGrant.IBillingCreditGrantConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.BillingCreditGrant.IBillingCreditGrantConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingCreditGrant(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingCreditGrant(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BillingCreditGrant resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BillingCreditGrant to import.</param>
        /// <param name="importFromId">The id of the existing BillingCreditGrant that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BillingCreditGrant to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BillingCreditGrant to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_credit_grant#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BillingCreditGrant that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BillingCreditGrant to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.BillingCreditGrant.BillingCreditGrant), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAmount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantAmount\"}}]")]
        public virtual void PutAmount(stripe.BillingCreditGrant.IBillingCreditGrantAmount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingCreditGrant.IBillingCreditGrantAmount)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApplicabilityConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfig\"}}]")]
        public virtual void PutApplicabilityConfig(stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCategory")]
        public virtual void ResetCategory()
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

        [JsiiMethod(name: "resetEffectiveAt")]
        public virtual void ResetEffectiveAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiresAt")]
        public virtual void ResetExpiresAt()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
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
        = GetStaticProperty<string>(typeof(stripe.BillingCreditGrant.BillingCreditGrant))!;

        [JsiiProperty(name: "amount", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantAmountOutputReference\"}")]
        public virtual stripe.BillingCreditGrant.BillingCreditGrantAmountOutputReference Amount
        {
            get => GetInstanceProperty<stripe.BillingCreditGrant.BillingCreditGrantAmountOutputReference>()!;
        }

        [JsiiProperty(name: "applicabilityConfig", typeJson: "{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfigOutputReference\"}")]
        public virtual stripe.BillingCreditGrant.BillingCreditGrantApplicabilityConfigOutputReference ApplicabilityConfig
        {
            get => GetInstanceProperty<stripe.BillingCreditGrant.BillingCreditGrantApplicabilityConfigOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "testClock", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TestClock
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updated", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Updated
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "voidedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VoidedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingCreditGrant.IBillingCreditGrantAmount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantAmount\"}]}}", isOptional: true)]
        public virtual object? AmountInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.BillingCreditGrant.IBillingCreditGrantApplicabilityConfig" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicabilityConfigInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.billingCreditGrant.BillingCreditGrantApplicabilityConfig\"}]}}", isOptional: true)]
        public virtual object? ApplicabilityConfigInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "categoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CategoryInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "effectiveAtInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EffectiveAtInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiresAtInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ExpiresAtInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "category", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Category
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
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

        [JsiiProperty(name: "effectiveAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EffectiveAt
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpiresAt
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
