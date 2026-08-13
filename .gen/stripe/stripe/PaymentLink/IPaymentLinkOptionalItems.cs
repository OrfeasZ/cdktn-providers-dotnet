using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkOptionalItems), fullyQualifiedName: "stripe.paymentLink.PaymentLinkOptionalItems")]
    public interface IPaymentLinkOptionalItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#price PaymentLink#price}.</summary>
        [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
        string Price
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#quantity PaymentLink#quantity}.</summary>
        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
        double Quantity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#adjustable_quantity PaymentLink#adjustable_quantity}.</summary>
        [JsiiProperty(name: "adjustableQuantity", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkOptionalItemsAdjustableQuantity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.PaymentLink.IPaymentLinkOptionalItemsAdjustableQuantity? AdjustableQuantity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkOptionalItems), fullyQualifiedName: "stripe.paymentLink.PaymentLinkOptionalItems")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkOptionalItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#price PaymentLink#price}.</summary>
            [JsiiProperty(name: "price", typeJson: "{\"primitive\":\"string\"}")]
            public string Price
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#quantity PaymentLink#quantity}.</summary>
            [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
            public double Quantity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#adjustable_quantity PaymentLink#adjustable_quantity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "adjustableQuantity", typeJson: "{\"fqn\":\"stripe.paymentLink.PaymentLinkOptionalItemsAdjustableQuantity\"}", isOptional: true)]
            public stripe.PaymentLink.IPaymentLinkOptionalItemsAdjustableQuantity? AdjustableQuantity
            {
                get => GetInstanceProperty<stripe.PaymentLink.IPaymentLinkOptionalItemsAdjustableQuantity?>();
            }
        }
    }
}
