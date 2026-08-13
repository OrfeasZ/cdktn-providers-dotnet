using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiClass(nativeType: typeof(stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFinancialAddressesOutputReference), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountFinancialAddressesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class TreasuryFinancialAccountFinancialAddressesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public TreasuryFinancialAccountFinancialAddressesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TreasuryFinancialAccountFinancialAddressesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TreasuryFinancialAccountFinancialAddressesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "aba", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFinancialAddressesAbaOutputReference\"}")]
        public virtual stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFinancialAddressesAbaOutputReference Aba
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.TreasuryFinancialAccountFinancialAddressesAbaOutputReference>()!;
        }

        [JsiiProperty(name: "supportedNetworks", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedNetworks
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountFinancialAddresses\"}", isOptional: true)]
        public virtual stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFinancialAddresses? InternalValue
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountFinancialAddresses?>();
            set => SetInstanceProperty(value);
        }
    }
}
