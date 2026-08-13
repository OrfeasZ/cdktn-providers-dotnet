using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentPaymentMethodDataUsBankAccount")]
    public class PaymentIntentPaymentMethodDataUsBankAccount : stripe.PaymentIntent.IPaymentIntentPaymentMethodDataUsBankAccount
    {
        /// <summary>Account holder type: individual or company.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_holder_type PaymentIntent#account_holder_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountHolderType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountHolderType
        {
            get;
            set;
        }

        /// <summary>Account number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_number PaymentIntent#account_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountNumber
        {
            get;
            set;
        }

        /// <summary>Account type: checkings or savings. Defaults to checking if omitted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#account_type PaymentIntent#account_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountType
        {
            get;
            set;
        }

        /// <summary>The ID of a Financial Connections Account to use as a payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#financial_connections_account PaymentIntent#financial_connections_account}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "financialConnectionsAccount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FinancialConnectionsAccount
        {
            get;
            set;
        }

        /// <summary>Routing number of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#routing_number PaymentIntent#routing_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingNumber
        {
            get;
            set;
        }
    }
}
