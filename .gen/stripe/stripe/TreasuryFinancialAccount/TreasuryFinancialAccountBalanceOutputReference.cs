using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TreasuryFinancialAccount
{
    [JsiiClass(nativeType: typeof(stripe.TreasuryFinancialAccount.TreasuryFinancialAccountBalanceOutputReference), fullyQualifiedName: "stripe.treasuryFinancialAccount.TreasuryFinancialAccountBalanceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class TreasuryFinancialAccountBalanceOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public TreasuryFinancialAccountBalanceOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TreasuryFinancialAccountBalanceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TreasuryFinancialAccountBalanceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cash", typeJson: "{\"fqn\":\"cdktn.NumberMap\"}")]
        public virtual Io.Cdktn.NumberMap Cash
        {
            get => GetInstanceProperty<Io.Cdktn.NumberMap>()!;
        }

        [JsiiProperty(name: "inboundPending", typeJson: "{\"fqn\":\"cdktn.NumberMap\"}")]
        public virtual Io.Cdktn.NumberMap InboundPending
        {
            get => GetInstanceProperty<Io.Cdktn.NumberMap>()!;
        }

        [JsiiProperty(name: "outboundPending", typeJson: "{\"fqn\":\"cdktn.NumberMap\"}")]
        public virtual Io.Cdktn.NumberMap OutboundPending
        {
            get => GetInstanceProperty<Io.Cdktn.NumberMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.treasuryFinancialAccount.TreasuryFinancialAccountBalance\"}", isOptional: true)]
        public virtual stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountBalance? InternalValue
        {
            get => GetInstanceProperty<stripe.TreasuryFinancialAccount.ITreasuryFinancialAccountBalance?>();
            set => SetInstanceProperty(value);
        }
    }
}
