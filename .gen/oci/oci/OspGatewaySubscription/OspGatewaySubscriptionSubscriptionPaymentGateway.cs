using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiByValue(fqn: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGateway")]
    public class OspGatewaySubscriptionSubscriptionPaymentGateway : oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGateway
    {
        /// <summary>merchant_defined_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#merchant_defined_data OspGatewaySubscription#merchant_defined_data}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "merchantDefinedData", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData\"}", isOptional: true)]
        public oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData? MerchantDefinedData
        {
            get;
            set;
        }
    }
}
