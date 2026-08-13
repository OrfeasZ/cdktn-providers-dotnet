using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiInterface(nativeType: typeof(IPaymentMethodBoleto), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodBoleto")]
    public interface IPaymentMethodBoleto
    {
        /// <summary>Uniquely identifies the customer tax id (CNPJ or CPF).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#tax_id PaymentMethod#tax_id}
        /// </remarks>
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}")]
        string TaxId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentMethodBoleto), fullyQualifiedName: "stripe.paymentMethod.PaymentMethodBoleto")]
        internal sealed class _Proxy : DeputyBase, stripe.PaymentMethod.IPaymentMethodBoleto
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Uniquely identifies the customer tax id (CNPJ or CPF).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#tax_id PaymentMethod#tax_id}
            /// </remarks>
            [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}")]
            public string TaxId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
