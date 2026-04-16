using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingMeter
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter stripe_billing_meter}.</summary>
    [JsiiClass(nativeType: typeof(stripe.BillingMeter.BillingMeter), fullyQualifiedName: "stripe.billingMeter.BillingMeter", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.billingMeter.BillingMeterConfig\"}}]")]
    public class BillingMeter : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter stripe_billing_meter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BillingMeter(Constructs.Construct scope, string id, stripe.BillingMeter.IBillingMeterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.BillingMeter.IBillingMeterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingMeter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BillingMeter(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a BillingMeter resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the BillingMeter to import.</param>
        /// <param name="importFromId">The id of the existing BillingMeter that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the BillingMeter to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the BillingMeter to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/billing_meter#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing BillingMeter that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the BillingMeter to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.BillingMeter.BillingMeter), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCustomerMapping", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingMeter.BillingMeterCustomerMapping\"}}]")]
        public virtual void PutCustomerMapping(stripe.BillingMeter.IBillingMeterCustomerMapping @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingMeter.IBillingMeterCustomerMapping)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultAggregation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingMeter.BillingMeterDefaultAggregation\"}}]")]
        public virtual void PutDefaultAggregation(stripe.BillingMeter.IBillingMeterDefaultAggregation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingMeter.IBillingMeterDefaultAggregation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putValueSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.billingMeter.BillingMeterValueSettings\"}}]")]
        public virtual void PutValueSettings(stripe.BillingMeter.IBillingMeterValueSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.BillingMeter.IBillingMeterValueSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomerMapping")]
        public virtual void ResetCustomerMapping()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDimensionPayloadKeys")]
        public virtual void ResetDimensionPayloadKeys()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventTimeWindow")]
        public virtual void ResetEventTimeWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValueSettings")]
        public virtual void ResetValueSettings()
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
        = GetStaticProperty<string>(typeof(stripe.BillingMeter.BillingMeter))!;

        [JsiiProperty(name: "customerMapping", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterCustomerMappingOutputReference\"}")]
        public virtual stripe.BillingMeter.BillingMeterCustomerMappingOutputReference CustomerMapping
        {
            get => GetInstanceProperty<stripe.BillingMeter.BillingMeterCustomerMappingOutputReference>()!;
        }

        [JsiiProperty(name: "defaultAggregation", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterDefaultAggregationOutputReference\"}")]
        public virtual stripe.BillingMeter.BillingMeterDefaultAggregationOutputReference DefaultAggregation
        {
            get => GetInstanceProperty<stripe.BillingMeter.BillingMeterDefaultAggregationOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "valueSettings", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterValueSettingsOutputReference\"}")]
        public virtual stripe.BillingMeter.BillingMeterValueSettingsOutputReference ValueSettings
        {
            get => GetInstanceProperty<stripe.BillingMeter.BillingMeterValueSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerMappingInput", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterCustomerMapping\"}", isOptional: true)]
        public virtual stripe.BillingMeter.IBillingMeterCustomerMapping? CustomerMappingInput
        {
            get => GetInstanceProperty<stripe.BillingMeter.IBillingMeterCustomerMapping?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultAggregationInput", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterDefaultAggregation\"}", isOptional: true)]
        public virtual stripe.BillingMeter.IBillingMeterDefaultAggregation? DefaultAggregationInput
        {
            get => GetInstanceProperty<stripe.BillingMeter.IBillingMeterDefaultAggregation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dimensionPayloadKeysInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DimensionPayloadKeysInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventTimeWindowInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventTimeWindowInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueSettingsInput", typeJson: "{\"fqn\":\"stripe.billingMeter.BillingMeterValueSettings\"}", isOptional: true)]
        public virtual stripe.BillingMeter.IBillingMeterValueSettings? ValueSettingsInput
        {
            get => GetInstanceProperty<stripe.BillingMeter.IBillingMeterValueSettings?>();
        }

        [JsiiProperty(name: "dimensionPayloadKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DimensionPayloadKeys
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventTimeWindow", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventTimeWindow
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
