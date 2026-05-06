using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentOptions")]
    public class OspGatewaySubscriptionSubscriptionPaymentOptions : oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#payment_method OspGatewaySubscription#payment_method}.</summary>
        [JsiiProperty(name: "paymentMethod", typeJson: "{\"primitive\":\"string\"}")]
        public string PaymentMethod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#credit_card_type OspGatewaySubscription#credit_card_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "creditCardType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreditCardType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#email_address OspGatewaySubscription#email_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#ext_billing_agreement_id OspGatewaySubscription#ext_billing_agreement_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "extBillingAgreementId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExtBillingAgreementId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#first_name OspGatewaySubscription#first_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FirstName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#last_digits OspGatewaySubscription#last_digits}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastDigits", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastDigits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#last_name OspGatewaySubscription#last_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#name_on_card OspGatewaySubscription#name_on_card}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nameOnCard", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NameOnCard
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#time_expiration OspGatewaySubscription#time_expiration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeExpiration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeExpiration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#wallet_instrument_id OspGatewaySubscription#wallet_instrument_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "walletInstrumentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WalletInstrumentId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#wallet_transaction_id OspGatewaySubscription#wallet_transaction_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "walletTransactionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WalletTransactionId
        {
            get;
            set;
        }
    }
}
