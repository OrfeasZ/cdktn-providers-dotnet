using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementRecipientVerification
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_recipient_verification stripe_v2_money_management_recipient_verification}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerification), fullyQualifiedName: "stripe.v2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerification", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationConfig\"}}]")]
    public class V2MoneyManagementRecipientVerification : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_recipient_verification stripe_v2_money_management_recipient_verification} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2MoneyManagementRecipientVerification(Constructs.Construct scope, string id, stripe.V2MoneyManagementRecipientVerification.IV2MoneyManagementRecipientVerificationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2MoneyManagementRecipientVerification.IV2MoneyManagementRecipientVerificationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementRecipientVerification(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementRecipientVerification(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2MoneyManagementRecipientVerification resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2MoneyManagementRecipientVerification to import.</param>
        /// <param name="importFromId">The id of the existing V2MoneyManagementRecipientVerification that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2MoneyManagementRecipientVerification to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2MoneyManagementRecipientVerification to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_recipient_verification#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2MoneyManagementRecipientVerification that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2MoneyManagementRecipientVerification to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerification), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetRecipient")]
        public virtual void ResetRecipient()
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
        = GetStaticProperty<string>(typeof(stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerification))!;

        [JsiiProperty(name: "consumedBy", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationConsumedByOutputReference\"}")]
        public virtual stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationConsumedByOutputReference ConsumedBy
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationConsumedByOutputReference>()!;
        }

        [JsiiProperty(name: "created", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Created
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "expiresAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExpiresAt
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

        [JsiiProperty(name: "matchResult", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MatchResult
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "matchResultDetails", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationMatchResultDetailsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationMatchResultDetailsOutputReference MatchResultDetails
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationMatchResultDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "statusTransitions", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationStatusTransitionsOutputReference\"}")]
        public virtual stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationStatusTransitionsOutputReference StatusTransitions
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementRecipientVerification.V2MoneyManagementRecipientVerificationStatusTransitionsOutputReference>()!;
        }

        [JsiiProperty(name: "verificationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VerificationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "payoutMethodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PayoutMethodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recipientInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecipientInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "payoutMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayoutMethod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recipient", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Recipient
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
