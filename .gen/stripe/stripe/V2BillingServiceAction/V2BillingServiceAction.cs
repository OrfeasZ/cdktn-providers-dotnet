using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action stripe_v2_billing_service_action}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2BillingServiceAction.V2BillingServiceAction), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceAction", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionConfig\"}}]")]
    public class V2BillingServiceAction : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action stripe_v2_billing_service_action} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2BillingServiceAction(Constructs.Construct scope, string id, stripe.V2BillingServiceAction.IV2BillingServiceActionConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2BillingServiceAction.IV2BillingServiceActionConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingServiceAction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingServiceAction(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2BillingServiceAction resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2BillingServiceAction to import.</param>
        /// <param name="importFromId">The id of the existing V2BillingServiceAction that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2BillingServiceAction to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2BillingServiceAction to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_billing_service_action#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2BillingServiceAction that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2BillingServiceAction to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2BillingServiceAction.V2BillingServiceAction), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCreditGrant", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrant\"}}]")]
        public virtual void PutCreditGrant(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCreditGrant")]
        public virtual void ResetCreditGrant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLookupKey")]
        public virtual void ResetLookupKey()
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
        = GetStaticProperty<string>(typeof(stripe.V2BillingServiceAction.V2BillingServiceAction))!;

        [JsiiProperty(name: "creditGrant", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantOutputReference\"}")]
        public virtual stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantOutputReference CreditGrant
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "creditGrantInput", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrant\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant? CreditGrantInput
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrant?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lookupKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LookupKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceIntervalCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ServiceIntervalCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceIntervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceIntervalInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "serviceInterval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceInterval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceIntervalCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ServiceIntervalCount
        {
            get => GetInstanceProperty<double>()!;
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
