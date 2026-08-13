using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentPaymentMethodDataBoleto), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataBoleto")]
    public interface ISetupIntentPaymentMethodDataBoleto
    {
        /// <summary>The tax ID of the customer (CPF for individual consumers or CNPJ for businesses consumers).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#tax_id SetupIntent#tax_id}
        /// </remarks>
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}")]
        string TaxId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentPaymentMethodDataBoleto), fullyQualifiedName: "stripe.setupIntent.SetupIntentPaymentMethodDataBoleto")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentPaymentMethodDataBoleto
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The tax ID of the customer (CPF for individual consumers or CNPJ for businesses consumers).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#tax_id SetupIntent#tax_id}
            /// </remarks>
            [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}")]
            public string TaxId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
