using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiClass(nativeType: typeof(stripe.Quote.QuoteTotalDetailsBreakdownOutputReference), fullyQualifiedName: "stripe.quote.QuoteTotalDetailsBreakdownOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuoteTotalDetailsBreakdownOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuoteTotalDetailsBreakdownOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuoteTotalDetailsBreakdownOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuoteTotalDetailsBreakdownOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "discounts", typeJson: "{\"fqn\":\"stripe.quote.QuoteTotalDetailsBreakdownDiscountsList\"}")]
        public virtual stripe.Quote.QuoteTotalDetailsBreakdownDiscountsList Discounts
        {
            get => GetInstanceProperty<stripe.Quote.QuoteTotalDetailsBreakdownDiscountsList>()!;
        }

        [JsiiProperty(name: "taxes", typeJson: "{\"fqn\":\"stripe.quote.QuoteTotalDetailsBreakdownTaxesList\"}")]
        public virtual stripe.Quote.QuoteTotalDetailsBreakdownTaxesList Taxes
        {
            get => GetInstanceProperty<stripe.Quote.QuoteTotalDetailsBreakdownTaxesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.quote.QuoteTotalDetailsBreakdown\"}", isOptional: true)]
        public virtual stripe.Quote.IQuoteTotalDetailsBreakdown? InternalValue
        {
            get => GetInstanceProperty<stripe.Quote.IQuoteTotalDetailsBreakdown?>();
            set => SetInstanceProperty(value);
        }
    }
}
