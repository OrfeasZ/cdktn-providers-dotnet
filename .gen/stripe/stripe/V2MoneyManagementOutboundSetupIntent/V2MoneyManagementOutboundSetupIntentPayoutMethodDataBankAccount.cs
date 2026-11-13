using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2MoneyManagementOutboundSetupIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.v2MoneyManagementOutboundSetupIntent.V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount")]
    public class V2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount : stripe.V2MoneyManagementOutboundSetupIntent.IV2MoneyManagementOutboundSetupIntentPayoutMethodDataBankAccount
    {
        /// <summary>The account number or IBAN of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#account_number V2MoneyManagementOutboundSetupIntent#account_number}
        /// </remarks>
        [JsiiProperty(name: "accountNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string AccountNumber
        {
            get;
            set;
        }

        /// <summary>The country code of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#country V2MoneyManagementOutboundSetupIntent#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}")]
        public string Country
        {
            get;
            set;
        }

        /// <summary>The currency of the bank account.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#currency V2MoneyManagementOutboundSetupIntent#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public string Currency
        {
            get;
            set;
        }

        /// <summary>Closed Enum. The type of the bank account (checking or savings).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#bank_account_type V2MoneyManagementOutboundSetupIntent#bank_account_type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bankAccountType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BankAccountType
        {
            get;
            set;
        }

        /// <summary>The branch number of the bank account, if present.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#branch_number V2MoneyManagementOutboundSetupIntent#branch_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "branchNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BranchNumber
        {
            get;
            set;
        }

        /// <summary>The routing number of the bank account, if present.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#routing_number V2MoneyManagementOutboundSetupIntent#routing_number}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routingNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoutingNumber
        {
            get;
            set;
        }

        /// <summary>The swift code of the bank account, if present.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/v2_money_management_outbound_setup_intent#swift_code V2MoneyManagementOutboundSetupIntent#swift_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "swiftCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SwiftCode
        {
            get;
            set;
        }
    }
}
