using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections")]
    public class PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections : stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#filters PaymentIntent#filters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"stripe.paymentIntent.PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters\"}", isOptional: true)]
        public stripe.PaymentIntent.IPaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters? Filters
        {
            get;
            set;
        }

        /// <summary>The list of permissions to request. The `payment_method` permission must be included.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#permissions PaymentIntent#permissions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Permissions
        {
            get;
            set;
        }

        /// <summary>Data features requested to be retrieved upon account creation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#prefetch PaymentIntent#prefetch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prefetch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Prefetch
        {
            get;
            set;
        }

        /// <summary>For webview integrations only.</summary>
        /// <remarks>
        /// Upon completing OAuth login in the native browser, the user will be redirected to this URL to return to your app.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#return_url PaymentIntent#return_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "returnUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReturnUrl
        {
            get;
            set;
        }
    }
}
