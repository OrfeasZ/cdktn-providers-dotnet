using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiInterface(nativeType: typeof(IOspGatewaySubscriptionSubscriptionPaymentGateway), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGateway")]
    public interface IOspGatewaySubscriptionSubscriptionPaymentGateway
    {
        /// <summary>merchant_defined_data block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#merchant_defined_data OspGatewaySubscription#merchant_defined_data}
        /// </remarks>
        [JsiiProperty(name: "merchantDefinedData", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData? MerchantDefinedData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOspGatewaySubscriptionSubscriptionPaymentGateway), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGateway")]
        internal sealed class _Proxy : DeputyBase, oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGateway
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>merchant_defined_data block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#merchant_defined_data OspGatewaySubscription#merchant_defined_data}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "merchantDefinedData", typeJson: "{\"fqn\":\"oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData\"}", isOptional: true)]
            public oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData? MerchantDefinedData
            {
                get => GetInstanceProperty<oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionPaymentGatewayMerchantDefinedData?>();
            }
        }
    }
}
