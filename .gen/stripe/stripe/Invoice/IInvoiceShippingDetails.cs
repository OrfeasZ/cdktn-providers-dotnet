using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Invoice
{
    [JsiiInterface(nativeType: typeof(IInvoiceShippingDetails), fullyQualifiedName: "stripe.invoice.InvoiceShippingDetails")]
    public interface IInvoiceShippingDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#address Invoice#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingDetailsAddress\"}")]
        stripe.Invoice.IInvoiceShippingDetailsAddress Address
        {
            get;
        }

        /// <summary>Recipient name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#name Invoice#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Recipient phone (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#phone Invoice#phone}
        /// </remarks>
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Phone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvoiceShippingDetails), fullyQualifiedName: "stripe.invoice.InvoiceShippingDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.Invoice.IInvoiceShippingDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#address Invoice#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.invoice.InvoiceShippingDetailsAddress\"}")]
            public stripe.Invoice.IInvoiceShippingDetailsAddress Address
            {
                get => GetInstanceProperty<stripe.Invoice.IInvoiceShippingDetailsAddress>()!;
            }

            /// <summary>Recipient name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#name Invoice#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Recipient phone (including extension).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/invoice#phone Invoice#phone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Phone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
