using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiByValue(fqn: "stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections")]
    public class SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections : stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#filters SetupIntent#filters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"stripe.setupIntent.SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters\"}", isOptional: true)]
        public stripe.SetupIntent.ISetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters? Filters
        {
            get;
            set;
        }

        /// <summary>The list of permissions to request. The `payment_method` permission must be included.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#permissions SetupIntent#permissions}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#prefetch SetupIntent#prefetch}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#return_url SetupIntent#return_url}
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
