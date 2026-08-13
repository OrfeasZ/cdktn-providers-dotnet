using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentMethod
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentMethod.PaymentMethodNzBankAccount")]
    public class PaymentMethodNzBankAccount : stripe.PaymentMethod.IPaymentMethodNzBankAccount
    {
        /// <summary>The account number for the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_number PaymentMethod#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountNumber
        {
            get;
            set;
        }

        /// <summary>The numeric code for the bank account's bank.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#bank_code PaymentMethod#bank_code}
        /// </remarks>
        [JsiiProperty(name: "bankCode", typeJson: "{\"primitive\":\"string\"}")]
        public string BankCode
        {
            get;
            set;
        }

        /// <summary>The numeric code for the bank account's bank branch.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#branch_code PaymentMethod#branch_code}
        /// </remarks>
        [JsiiProperty(name: "branchCode", typeJson: "{\"primitive\":\"string\"}")]
        public string BranchCode
        {
            get;
            set;
        }

        /// <summary>The suffix of the bank account number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#suffix PaymentMethod#suffix}
        /// </remarks>
        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        public string Suffix
        {
            get;
            set;
        }

        /// <summary>The name on the bank account.</summary>
        /// <remarks>
        /// Only present if the account holder name is different from the name of the authorized signatory collected in the PaymentMethod’s billing details.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#account_holder_name PaymentMethod#account_holder_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountHolderName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AccountHolderName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_method#reference PaymentMethod#reference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reference
        {
            get;
            set;
        }
    }
}
