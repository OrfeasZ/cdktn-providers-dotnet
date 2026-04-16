using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiClass(nativeType: typeof(stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantAmountOutputReference), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2BillingServiceActionCreditGrantAmountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2BillingServiceActionCreditGrantAmountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2BillingServiceActionCreditGrantAmountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingServiceActionCreditGrantAmountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomPricingUnit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountCustomPricingUnit\"}}]")]
        public virtual void PutCustomPricingUnit(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountCustomPricingUnit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountCustomPricingUnit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonetary", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetary\"}}]")]
        public virtual void PutMonetary(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomPricingUnit")]
        public virtual void ResetCustomPricingUnit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonetary")]
        public virtual void ResetMonetary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customPricingUnit", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountCustomPricingUnitOutputReference\"}")]
        public virtual stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantAmountCustomPricingUnitOutputReference CustomPricingUnit
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantAmountCustomPricingUnitOutputReference>()!;
        }

        [JsiiProperty(name: "monetary", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetaryOutputReference\"}")]
        public virtual stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetaryOutputReference Monetary
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetaryOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customPricingUnitInput", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountCustomPricingUnit\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountCustomPricingUnit? CustomPricingUnitInput
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountCustomPricingUnit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monetaryInput", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmountMonetary\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary? MonetaryInput
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmountMonetary?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantAmount\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount? InternalValue
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantAmount?>();
            set => SetInstanceProperty(value);
        }
    }
}
