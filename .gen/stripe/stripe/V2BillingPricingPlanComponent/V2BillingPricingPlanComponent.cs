using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingPricingPlanComponent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component stripe_v2_billing_pricing_plan_component}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponent), fullyQualifiedName: "stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentConfig\"}}]")]
    public class V2BillingPricingPlanComponent : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component stripe_v2_billing_pricing_plan_component} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2BillingPricingPlanComponent(Constructs.Construct scope, string id, stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingPricingPlanComponent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingPricingPlanComponent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2BillingPricingPlanComponent resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2BillingPricingPlanComponent to import.</param>
        /// <param name="importFromId">The id of the existing V2BillingPricingPlanComponent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2BillingPricingPlanComponent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2BillingPricingPlanComponent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_pricing_plan_component#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2BillingPricingPlanComponent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2BillingPricingPlanComponent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLicenseFee", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentLicenseFee\"}}]")]
        public virtual void PutLicenseFee(stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentLicenseFee @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentLicenseFee)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRateCard", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentRateCard\"}}]")]
        public virtual void PutRateCard(stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentRateCard @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentRateCard)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServiceAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentServiceAction\"}}]")]
        public virtual void PutServiceAction(stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentServiceAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentServiceAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLicenseFee")]
        public virtual void ResetLicenseFee()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLookupKey")]
        public virtual void ResetLookupKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRateCard")]
        public virtual void ResetRateCard()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceAction")]
        public virtual void ResetServiceAction()
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
        = GetStaticProperty<string>(typeof(stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponent))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "licenseFee", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentLicenseFeeOutputReference\"}")]
        public virtual stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponentLicenseFeeOutputReference LicenseFee
        {
            get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponentLicenseFeeOutputReference>()!;
        }

        [JsiiProperty(name: "pricingPlan", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricingPlan
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pricingPlanVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricingPlanVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rateCard", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentRateCardOutputReference\"}")]
        public virtual stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponentRateCardOutputReference RateCard
        {
            get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponentRateCardOutputReference>()!;
        }

        [JsiiProperty(name: "serviceAction", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentServiceActionOutputReference\"}")]
        public virtual stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponentServiceActionOutputReference ServiceAction
        {
            get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.V2BillingPricingPlanComponentServiceActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "licenseFeeInput", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentLicenseFee\"}", isOptional: true)]
        public virtual stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentLicenseFee? LicenseFeeInput
        {
            get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentLicenseFee?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lookupKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LookupKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pricingPlanIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PricingPlanIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rateCardInput", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentRateCard\"}", isOptional: true)]
        public virtual stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentRateCard? RateCardInput
        {
            get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentRateCard?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceActionInput", typeJson: "{\"fqn\":\"stripe.v2BillingPricingPlanComponent.V2BillingPricingPlanComponentServiceAction\"}", isOptional: true)]
        public virtual stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentServiceAction? ServiceActionInput
        {
            get => GetInstanceProperty<stripe.V2BillingPricingPlanComponent.IV2BillingPricingPlanComponentServiceAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "lookupKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LookupKey
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

        [JsiiProperty(name: "pricingPlanId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricingPlanId
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
