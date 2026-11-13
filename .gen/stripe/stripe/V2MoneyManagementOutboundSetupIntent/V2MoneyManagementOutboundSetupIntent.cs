using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundSetupIntent
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent stripe_v2_money_management_outbound_setup_intent}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntent), fullyQualifiedName: "stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntent", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentConfig\"}}]")]
    public class V2MoneyManagementOutboundSetupIntent : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent stripe_v2_money_management_outbound_setup_intent} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2MoneyManagementOutboundSetupIntent(Constructs.Construct scope, string id, stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementOutboundSetupIntent(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementOutboundSetupIntent(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2MoneyManagementOutboundSetupIntent resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2MoneyManagementOutboundSetupIntent to import.</param>
        /// <param name="importFromId">The id of the existing V2MoneyManagementOutboundSetupIntent that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2MoneyManagementOutboundSetupIntent to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2MoneyManagementOutboundSetupIntent to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2MoneyManagementOutboundSetupIntent that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2MoneyManagementOutboundSetupIntent to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntent), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPayoutMethodData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodData\"}}]")]
        public virtual void PutPayoutMethodData(stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPayoutMethod")]
        public virtual void ResetPayoutMethod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPayoutMethodData")]
        public virtual void ResetPayoutMethodData()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsageIntent")]
        public virtual void ResetUsageIntent()
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
        = GetStaticProperty<string>(typeof(stripe.V2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntent))!;

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "payoutMethodData", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference\"}")]
        public virtual stripe.V2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference PayoutMethodData
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodData" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "payoutMethodDataInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodData\"}]}}", isOptional: true)]
        public virtual object? PayoutMethodDataInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "payoutMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PayoutMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usageIntentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UsageIntentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "payoutMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayoutMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usageIntent", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UsageIntent
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
