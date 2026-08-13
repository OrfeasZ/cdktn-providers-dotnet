using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.IssuingCardholder
{
    [JsiiInterface(nativeType: typeof(IIssuingCardholderCompany), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderCompany")]
    public interface IIssuingCardholderCompany
    {
        /// <summary>The entity's business ID number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#tax_id IssuingCardholder#tax_id}
        /// </remarks>
        [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TaxId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIssuingCardholderCompany), fullyQualifiedName: "stripe.issuingCardholder.IssuingCardholderCompany")]
        internal sealed class _Proxy : DeputyBase, stripe.IssuingCardholder.IIssuingCardholderCompany
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The entity's business ID number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/issuing_cardholder#tax_id IssuingCardholder#tax_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "taxId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TaxId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
