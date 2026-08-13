using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceDiscounts), fullyQualifiedName: "stripe.invoice.InvoiceDiscounts")]
    public interface IInvoiceDiscounts
    {
        /// <summary>ID of the coupon to create a new discount for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#coupon Invoice#coupon}
        /// </remarks>
        [JsiiProperty(name: "coupon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Coupon
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of an existing discount on the object (or one of its ancestors) to reuse.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#discount Invoice#discount}
        /// </remarks>
        [JsiiProperty(name: "discount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Discount
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of the promotion code to create a new discount for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#promotion_code Invoice#promotion_code}
        /// </remarks>
        [JsiiProperty(name: "promotionCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PromotionCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceDiscounts), fullyQualifiedName: "stripe.invoice.InvoiceDiscounts")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceDiscounts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the coupon to create a new discount for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#coupon Invoice#coupon}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "coupon", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Coupon
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of an existing discount on the object (or one of its ancestors) to reuse.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#discount Invoice#discount}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "discount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Discount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of the promotion code to create a new discount for.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#promotion_code Invoice#promotion_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "promotionCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PromotionCode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
