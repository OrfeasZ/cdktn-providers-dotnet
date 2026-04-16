using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2BillingServiceAction
{
    [JsiiClass(nativeType: typeof(stripe.V2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference), fullyQualifiedName: "stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2BillingServiceActionCreditGrantApplicabilityConfigScopeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetBillableItems")]
        public virtual void ResetBillableItems()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriceType")]
        public virtual void ResetPriceType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "billableItemsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? BillableItemsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PriceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "billableItems", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BillableItems
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "priceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PriceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.v2BillingServiceAction.V2BillingServiceActionCreditGrantApplicabilityConfigScope\"}", isOptional: true)]
        public virtual stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfigScope? InternalValue
        {
            get => GetInstanceProperty<stripe.V2BillingServiceAction.IV2BillingServiceActionCreditGrantApplicabilityConfigScope?>();
            set => SetInstanceProperty(value);
        }
    }
}
