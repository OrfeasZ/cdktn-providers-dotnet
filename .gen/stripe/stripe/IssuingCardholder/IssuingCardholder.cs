using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder stripe_issuing_cardholder}.</summary>
    [JsiiClass(nativeType: typeof(stripe.IssuingCardholder.IssuingCardholder), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholder", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderConfig\"}}]")]
    public class IssuingCardholder : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder stripe_issuing_cardholder} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public IssuingCardholder(Constructs.Construct scope, string id, stripe.IssuingCardholder.IIssuingCardholderConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.IssuingCardholder.IIssuingCardholderConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCardholder(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IssuingCardholder(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a IssuingCardholder resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the IssuingCardholder to import.</param>
        /// <param name="importFromId">The id of the existing IssuingCardholder that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the IssuingCardholder to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the IssuingCardholder to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing IssuingCardholder that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the IssuingCardholder to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.IssuingCardholder.IssuingCardholder), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBilling", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderBilling\"}}]")]
        public virtual void PutBilling(stripe.IssuingCardholder.IIssuingCardholderBilling @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCardholder.IIssuingCardholderBilling)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCompany", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderCompany\"}}]")]
        public virtual void PutCompany(stripe.IssuingCardholder.IIssuingCardholderCompany @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCardholder.IIssuingCardholderCompany)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIndividual", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividual\"}}]")]
        public virtual void PutIndividual(stripe.IssuingCardholder.IIssuingCardholderIndividual @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCardholder.IIssuingCardholderIndividual)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSpendingControls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderSpendingControls\"}}]")]
        public virtual void PutSpendingControls(stripe.IssuingCardholder.IIssuingCardholderSpendingControls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.IssuingCardholder.IIssuingCardholderSpendingControls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCompany")]
        public virtual void ResetCompany()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmail")]
        public virtual void ResetEmail()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndividual")]
        public virtual void ResetIndividual()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPhoneNumber")]
        public virtual void ResetPhoneNumber()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredLocales")]
        public virtual void ResetPreferredLocales()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSpendingControls")]
        public virtual void ResetSpendingControls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
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
        = GetStaticProperty<string>(typeof(stripe.IssuingCardholder.IssuingCardholder))!;

        [JsiiProperty(name: "billing", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderBillingOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderBillingOutputReference Billing
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderBillingOutputReference>()!;
        }

        [JsiiProperty(name: "company", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderCompanyOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderCompanyOutputReference Company
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderCompanyOutputReference>()!;
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

        [JsiiProperty(name: "individual", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividualOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderIndividualOutputReference Individual
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderIndividualOutputReference>()!;
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

        [JsiiProperty(name: "requirements", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderRequirementsOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderRequirementsOutputReference Requirements
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderRequirementsOutputReference>()!;
        }

        [JsiiProperty(name: "spendingControls", typeJson: "{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderSpendingControlsOutputReference\"}")]
        public virtual stripe.IssuingCardholder.IssuingCardholderSpendingControlsOutputReference SpendingControls
        {
            get => GetInstanceProperty<stripe.IssuingCardholder.IssuingCardholderSpendingControlsOutputReference>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderBilling" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "billingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderBilling\"}]}}", isOptional: true)]
        public virtual object? BillingInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderCompany" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "companyInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderCompany\"}]}}", isOptional: true)]
        public virtual object? CompanyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailInput
        {
            get => GetInstanceProperty<string?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderIndividual" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "individualInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderIndividual\"}]}}", isOptional: true)]
        public virtual object? IndividualInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "phoneNumberInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PhoneNumberInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredLocalesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PreferredLocalesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.IssuingCardholder.IIssuingCardholderSpendingControls" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spendingControlsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.issuingCardholder.IssuingCardholderSpendingControls\"}]}}", isOptional: true)]
        public virtual object? SpendingControlsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Email
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PhoneNumber
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredLocales", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PreferredLocales
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
