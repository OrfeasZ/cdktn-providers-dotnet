using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InvoicingInvoiceUnit
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.invoicingInvoiceUnit.InvoicingInvoiceUnitRule")]
    public class InvoicingInvoiceUnitRule : aws.InvoicingInvoiceUnit.IInvoicingInvoiceUnitRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/invoicing_invoice_unit#linked_accounts InvoicingInvoiceUnit#linked_accounts}.</summary>
        [JsiiProperty(name: "linkedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] LinkedAccounts
        {
            get;
            set;
        }
    }
}
