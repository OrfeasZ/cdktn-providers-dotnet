using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Quote
{
    [JsiiClass(nativeType: typeof(stripe.Quote.QuoteTotalDetailsOutputReference), fullyQualifiedName: "stripe.quote.QuoteTotalDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuoteTotalDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuoteTotalDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuoteTotalDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuoteTotalDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amountDiscount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountDiscount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountShipping", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountShipping
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "amountTax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AmountTax
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "breakdown", typeJson: "{\"fqn\":\"stripe.quote.QuoteTotalDetailsBreakdownOutputReference\"}")]
        public virtual stripe.Quote.QuoteTotalDetailsBreakdownOutputReference Breakdown
        {
            get => GetInstanceProperty<stripe.Quote.QuoteTotalDetailsBreakdownOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.quote.QuoteTotalDetails\"}", isOptional: true)]
        public virtual stripe.Quote.IQuoteTotalDetails? InternalValue
        {
            get => GetInstanceProperty<stripe.Quote.IQuoteTotalDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
