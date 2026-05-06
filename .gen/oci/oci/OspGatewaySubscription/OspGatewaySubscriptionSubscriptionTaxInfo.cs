using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OspGatewaySubscription
{
    [JsiiByValue(fqn: "oci.ospGatewaySubscription.OspGatewaySubscriptionSubscriptionTaxInfo")]
    public class OspGatewaySubscriptionSubscriptionTaxInfo : oci.OspGatewaySubscription.IOspGatewaySubscriptionSubscriptionTaxInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#no_tax_reason_code OspGatewaySubscription#no_tax_reason_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noTaxReasonCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NoTaxReasonCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#no_tax_reason_code_details OspGatewaySubscription#no_tax_reason_code_details}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noTaxReasonCodeDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NoTaxReasonCodeDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_cnpj OspGatewaySubscription#tax_cnpj}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taxCnpj", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxCnpj
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_payer_id OspGatewaySubscription#tax_payer_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taxPayerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxPayerId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/osp_gateway_subscription#tax_reg_number OspGatewaySubscription#tax_reg_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "taxRegNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TaxRegNumber
        {
            get;
            set;
        }
    }
}
