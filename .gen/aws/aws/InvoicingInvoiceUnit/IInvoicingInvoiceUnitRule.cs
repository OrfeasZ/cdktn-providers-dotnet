using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.InvoicingInvoiceUnit
{
    [JsiiInterface(nativeType: typeof(IInvoicingInvoiceUnitRule), fullyQualifiedName: "aws.invoicingInvoiceUnit.InvoicingInvoiceUnitRule")]
    public interface IInvoicingInvoiceUnitRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/invoicing_invoice_unit#linked_accounts InvoicingInvoiceUnit#linked_accounts}.</summary>
        [JsiiProperty(name: "linkedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LinkedAccounts
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoicingInvoiceUnitRule), fullyQualifiedName: "aws.invoicingInvoiceUnit.InvoicingInvoiceUnitRule")]
        internal sealed class _Proxy : DeputyBase, aws.InvoicingInvoiceUnit.IInvoicingInvoiceUnitRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/invoicing_invoice_unit#linked_accounts InvoicingInvoiceUnit#linked_accounts}.</summary>
            [JsiiProperty(name: "linkedAccounts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LinkedAccounts
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
