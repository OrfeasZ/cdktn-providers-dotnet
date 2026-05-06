using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiInterface(nativeType: typeof(IOspGatewaySubscriptionSubscriptionTaxInfo), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfo")]
    public interface IOspGatewaySubscriptionSubscriptionTaxInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#no_tax_reason_code OspGatewaySubscription#no_tax_reason_code}.</summary>
        [JsiiProperty(name: "noTaxReasonCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NoTaxReasonCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#no_tax_reason_code_details OspGatewaySubscription#no_tax_reason_code_details}.</summary>
        [JsiiProperty(name: "noTaxReasonCodeDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NoTaxReasonCodeDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_cnpj OspGatewaySubscription#tax_cnpj}.</summary>
        [JsiiProperty(name: "taxCnpj", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxCnpj
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_payer_id OspGatewaySubscription#tax_payer_id}.</summary>
        [JsiiProperty(name: "taxPayerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxPayerId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_reg_number OspGatewaySubscription#tax_reg_number}.</summary>
        [JsiiProperty(name: "taxRegNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxRegNumber
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOspGatewaySubscriptionSubscriptionTaxInfo), fullyQualifiedName: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfo")]
        internal sealed class _Proxy : DeputyBase, oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionTaxInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#no_tax_reason_code OspGatewaySubscription#no_tax_reason_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noTaxReasonCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NoTaxReasonCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#no_tax_reason_code_details OspGatewaySubscription#no_tax_reason_code_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noTaxReasonCodeDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NoTaxReasonCodeDetails
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_cnpj OspGatewaySubscription#tax_cnpj}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taxCnpj", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxCnpj
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_payer_id OspGatewaySubscription#tax_payer_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taxPayerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxPayerId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_reg_number OspGatewaySubscription#tax_reg_number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "taxRegNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxRegNumber
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
