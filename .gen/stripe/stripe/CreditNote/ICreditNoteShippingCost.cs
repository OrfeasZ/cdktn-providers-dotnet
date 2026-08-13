using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.CreditNote
{
    [JsiiInterface(nativeType: typeof(ICreditNoteShippingCost), fullyQualifiedName: "stripe.creditNote.CreditNoteShippingCost")]
    public interface ICreditNoteShippingCost
    {
        /// <summary>The ID of the ShippingRate for this invoice.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#shipping_rate CreditNote#shipping_rate}
        /// </remarks>
        [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShippingRate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICreditNoteShippingCost), fullyQualifiedName: "stripe.creditNote.CreditNoteShippingCost")]
        internal sealed class _Proxy : DeputyBase, stripe.CreditNote.ICreditNoteShippingCost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the ShippingRate for this invoice.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/credit_note#shipping_rate CreditNote#shipping_rate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shippingRate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShippingRate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
