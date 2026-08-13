using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodBoleto")]
    public class PaymentMethodBoleto : stripe.PaymentMethod.IPaymentMethodBoleto
    {
        /// <summary>Uniquely identifies the customer tax id (CNPJ or CPF).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#tax_id PaymentMethod#tax_id}
        /// </remarks>
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}")]
        public string TaxId
        {
            get;
            set;
        }
    }
}
