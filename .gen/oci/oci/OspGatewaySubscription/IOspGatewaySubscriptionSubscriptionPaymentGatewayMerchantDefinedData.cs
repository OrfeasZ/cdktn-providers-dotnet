using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiInterface(nativeType: typeof(IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData")]
    public interface IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#cloud_account_name OspGatewaySubscription#cloud_account_name}.</summary>
        [JsiiProperty(name: "cloudAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudAccountName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#promo_type OspGatewaySubscription#promo_type}.</summary>
        [JsiiProperty(name: "promoType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PromoType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData")]
        internal sealed class _Proxy : DeputyBase, oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#cloud_account_name OspGatewaySubscription#cloud_account_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudAccountName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudAccountName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#promo_type OspGatewaySubscription#promo_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "promoType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PromoType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
