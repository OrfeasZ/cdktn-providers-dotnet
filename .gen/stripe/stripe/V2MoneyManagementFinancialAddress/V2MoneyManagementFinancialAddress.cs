using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementFinancialAddress
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address stripe_v2_money_management_financial_address}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddress), fullyQualifiedName: "stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddress", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressConfig\"}}]")]
    public class V2MoneyManagementFinancialAddress : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address stripe_v2_money_management_financial_address} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2MoneyManagementFinancialAddress(Constructs.Construct scope, string id, stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementFinancialAddress(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2MoneyManagementFinancialAddress(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2MoneyManagementFinancialAddress resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2MoneyManagementFinancialAddress to import.</param>
        /// <param name="importFromId">The id of the existing V2MoneyManagementFinancialAddress that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2MoneyManagementFinancialAddress to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2MoneyManagementFinancialAddress to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_financial_address#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2MoneyManagementFinancialAddress that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2MoneyManagementFinancialAddress to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddress), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putBankAccount", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccount\"}}]")]
        public virtual void PutBankAccount(stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBankAccount")]
        public virtual void ResetBankAccount()
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
        = GetStaticProperty<string>(typeof(stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddress))!;

        [JsiiProperty(name: "bankAccount", typeJson: "{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountOutputReference\"}")]
        public virtual stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountOutputReference BankAccount
        {
            get => GetInstanceProperty<stripe.V2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccountOutputReference>()!;
        }

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

        [JsiiProperty(name: "settlementCurrency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SettlementCurrency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="stripe.V2MoneyManagementFinancialAddress.IV2MoneyManagementFinancialAddressBankAccount" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bankAccountInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"stripe.v2MoneyManagementFinancialAddress.V2MoneyManagementFinancialAddressBankAccount\"}]}}", isOptional: true)]
        public virtual object? BankAccountInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "financialAccountInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FinancialAccountInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "financialAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FinancialAccount
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
