using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ShippingRate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate stripe_shipping_rate}.</summary>
    [JsiiClass(nativeType: typeof(stripe.ShippingRate.ShippingRate), fullyQualifiedName: "stripe.shippingRate.ShippingRate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.shippingRate.ShippingRateConfig\"}}]")]
    public class ShippingRate : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate stripe_shipping_rate} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ShippingRate(Constructs.Construct scope, string id, stripe.ShippingRate.IShippingRateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.ShippingRate.IShippingRateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ShippingRate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ShippingRate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ShippingRate resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ShippingRate to import.</param>
        /// <param name="importFromId">The id of the existing ShippingRate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ShippingRate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ShippingRate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/shipping_rate#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ShippingRate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ShippingRate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.ShippingRate.ShippingRate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDeliveryEstimate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimate\"}}]")]
        public virtual void PutDeliveryEstimate(stripe.ShippingRate.IShippingRateDeliveryEstimate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ShippingRate.IShippingRateDeliveryEstimate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedAmount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmount\"}}]")]
        public virtual void PutFixedAmount(stripe.ShippingRate.IShippingRateFixedAmount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ShippingRate.IShippingRateFixedAmount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeliveryEstimate")]
        public virtual void ResetDeliveryEstimate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFixedAmount")]
        public virtual void ResetFixedAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxBehavior")]
        public virtual void ResetTaxBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaxCode")]
        public virtual void ResetTaxCode()
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
        = GetStaticProperty<string>(typeof(stripe.ShippingRate.ShippingRate))!;

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "deliveryEstimate", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimateOutputReference\"}")]
        public virtual stripe.ShippingRate.ShippingRateDeliveryEstimateOutputReference DeliveryEstimate
        {
            get => GetInstanceProperty<stripe.ShippingRate.ShippingRateDeliveryEstimateOutputReference>()!;
        }

        [JsiiProperty(name: "fixedAmount", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmountOutputReference\"}")]
        public virtual stripe.ShippingRate.ShippingRateFixedAmountOutputReference FixedAmount
        {
            get => GetInstanceProperty<stripe.ShippingRate.ShippingRateFixedAmountOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deliveryEstimateInput", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateDeliveryEstimate\"}", isOptional: true)]
        public virtual stripe.ShippingRate.IShippingRateDeliveryEstimate? DeliveryEstimateInput
        {
            get => GetInstanceProperty<stripe.ShippingRate.IShippingRateDeliveryEstimate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedAmountInput", typeJson: "{\"fqn\":\"stripe.shippingRate.ShippingRateFixedAmount\"}", isOptional: true)]
        public virtual stripe.ShippingRate.IShippingRateFixedAmount? FixedAmountInput
        {
            get => GetInstanceProperty<stripe.ShippingRate.IShippingRateFixedAmount?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaxBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taxCodeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaxCodeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
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

        [JsiiProperty(name: "taxBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaxBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taxCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaxCode
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
