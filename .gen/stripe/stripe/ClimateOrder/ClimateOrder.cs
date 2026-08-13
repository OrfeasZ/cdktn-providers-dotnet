using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ClimateOrder
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/climate_order stripe_climate_order}.</summary>
    [JsiiClass(nativeType: typeof(stripe.ClimateOrder.ClimateOrder), fullyQualifiedName: "stripe.climateOrder.ClimateOrder", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.climateOrder.ClimateOrderConfig\"}}]")]
    public class ClimateOrder : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/climate_order stripe_climate_order} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ClimateOrder(Constructs.Construct scope, string id, stripe.ClimateOrder.IClimateOrderConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.ClimateOrder.IClimateOrderConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ClimateOrder(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ClimateOrder(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ClimateOrder resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ClimateOrder to import.</param>
        /// <param name="importFromId">The id of the existing ClimateOrder that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ClimateOrder to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ClimateOrder to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/climate_order#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ClimateOrder that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ClimateOrder to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.ClimateOrder.ClimateOrder), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBeneficiary", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.climateOrder.ClimateOrderBeneficiary\"}}]")]
        public virtual void PutBeneficiary(stripe.ClimateOrder.IClimateOrderBeneficiary @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.ClimateOrder.IClimateOrderBeneficiary)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmount")]
        public virtual void ResetAmount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBeneficiary")]
        public virtual void ResetBeneficiary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCurrency")]
        public virtual void ResetCurrency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricTons")]
        public virtual void ResetMetricTons()
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
        = GetStaticProperty<string>(typeof(stripe.ClimateOrder.ClimateOrder))!;

        [JsiiProperty(name: "amountFees", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountFees
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountSubtotal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountSubtotal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountTotal", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountTotal
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "beneficiary", typeJson: "{\"fqn\":\"stripe.climateOrder.ClimateOrderBeneficiaryOutputReference\"}")]
        public virtual stripe.ClimateOrder.ClimateOrderBeneficiaryOutputReference Beneficiary
        {
            get => GetInstanceProperty<stripe.ClimateOrder.ClimateOrderBeneficiaryOutputReference>()!;
        }

        [JsiiProperty(name: "canceledAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CanceledAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cancellationReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CancellationReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "confirmedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConfirmedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Created
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "delayedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DelayedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "deliveredAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DeliveredAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "deliveryDetails", typeJson: "{\"fqn\":\"stripe.climateOrder.ClimateOrderDeliveryDetailsList\"}")]
        public virtual stripe.ClimateOrder.ClimateOrderDeliveryDetailsList DeliveryDetails
        {
            get => GetInstanceProperty<stripe.ClimateOrder.ClimateOrderDeliveryDetailsList>()!;
        }

        [JsiiProperty(name: "expectedDeliveryYear", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ExpectedDeliveryYear
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

        [JsiiProperty(name: "productSubstitutedAt", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProductSubstitutedAt
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AmountInput
        {
            get => GetInstanceProperty<double?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.ClimateOrder.IClimateOrderBeneficiary" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "beneficiaryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.climateOrder.ClimateOrderBeneficiary\"}]}}", isOptional: true)]
        public virtual object? BeneficiaryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "currencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CurrencyInput
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
        [JsiiProperty(name: "metricTonsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MetricTonsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "productInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProductInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "amount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Amount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
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

        [JsiiProperty(name: "metricTons", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricTons
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "product", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Product
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
