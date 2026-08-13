using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Charge
{
    [JsiiClass(nativeType: typeof(stripe.Charge.ChargeOutcomeOutputReference), fullyQualifiedName: "stripe.charge.ChargeOutcomeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChargeOutcomeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChargeOutcomeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChargeOutcomeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChargeOutcomeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdviceCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkAdviceCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAdviceCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkDeclineCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkDeclineCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Reason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RiskLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "riskScore", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RiskScore
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Rule
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sellerMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SellerMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.charge.ChargeOutcome\"}", isOptional: true)]
        public virtual stripe.Charge.IChargeOutcome? InternalValue
        {
            get => GetInstanceProperty<stripe.Charge.IChargeOutcome?>();
            set => SetInstanceProperty(value);
        }
    }
}
