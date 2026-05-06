using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiByValue(fqn: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData")]
    public class OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData : oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#cloud_account_name OspGatewaySubscription#cloud_account_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudAccountName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#promo_type OspGatewaySubscription#promo_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "promoType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PromoType
        {
            get;
            set;
        }
    }
}
