using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodDataBoleto")]
    public class SetupIntentPaymentMethodDataBoleto : stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto
    {
        /// <summary>The tax ID of the customer (CPF for individual consumers or CNPJ for businesses consumers).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#tax_id SetupIntent#tax_id}
        /// </remarks>
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}")]
        public string TaxId
        {
            get;
            set;
        }
    }
}
