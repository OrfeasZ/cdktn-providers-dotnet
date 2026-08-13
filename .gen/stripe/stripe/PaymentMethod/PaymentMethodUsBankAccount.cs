using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodUsBankAccount")]
    public class PaymentMethodUsBankAccount : stripe.PaymentMethod.IPaymentMethodUsBankAccount
    {
        /// <summary>Account holder type: individual or company.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_holder_type PaymentMethod#account_holder_type}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_type PaymentMethod#account_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountType
        {
            get;
            set;
        }

        /// <summary>The ID of the Financial Connections Account used to create the payment method.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#financial_connections_account PaymentMethod#financial_connections_account}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#routing_number PaymentMethod#routing_number}
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
