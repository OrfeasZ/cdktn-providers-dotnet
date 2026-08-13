using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentLink
{
    [JsiiInterface(nativeType: typeof(IPaymentLinkCustomFieldsLabel), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFieldsLabel")]
    public interface IPaymentLinkCustomFieldsLabel
    {
        /// <summary>Custom text for the label, displayed to the customer. Up to 50 characters.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom PaymentLink#custom}
        /// </remarks>
        [JsiiProperty(name: "custom", typeJson: "{\"primitive\":\"string\"}")]
        string Custom
        {
            get;
        }

        /// <summary>The type of the label.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentLinkCustomFieldsLabel), fullyQualifiedName: "stripe.paymentLink.PaymentLinkCustomFieldsLabel")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentLink.IPaymentLinkCustomFieldsLabel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Custom text for the label, displayed to the customer. Up to 50 characters.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#custom PaymentLink#custom}
            /// </remarks>
            [JsiiProperty(name: "custom", typeJson: "{\"primitive\":\"string\"}")]
            public string Custom
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of the label.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_link#type PaymentLink#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
