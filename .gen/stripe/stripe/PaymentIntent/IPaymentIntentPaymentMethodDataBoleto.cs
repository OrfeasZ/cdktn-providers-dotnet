using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiInterface(nativeType: typeof(IPaymentIntentPaymentMethodDataBoleto), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataBoleto")]
    public interface IPaymentIntentPaymentMethodDataBoleto
    {
        /// <summary>The tax ID of the customer (CPF for individual consumers or CNPJ for businesses consumers).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#tax_id PaymentIntent#tax_id}
        /// </remarks>
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}")]
        string TaxId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentIntentPaymentMethodDataBoleto), fullyQualifiedName: "stripe.paymentIntent.PaymentIntentPaymentMethodDataBoleto")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentIntent.IPaymentIntentPaymentMethodDataBoleto
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The tax ID of the customer (CPF for individual consumers or CNPJ for businesses consumers).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#tax_id PaymentIntent#tax_id}
            /// </remarks>
            [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}")]
            public string TaxId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
