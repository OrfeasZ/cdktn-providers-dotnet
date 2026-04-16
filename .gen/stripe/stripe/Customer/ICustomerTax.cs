using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerTax), fullyQualifiedName: "stripe.customer.CustomerTax")]
    public interface ICustomerTax
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#ip_address Customer#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>A flag that indicates when Stripe should validate the customer tax location. Defaults to `deferred`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#validate_location Customer#validate_location}
        /// </remarks>
        [JsiiProperty(name: "validateLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidateLocation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerTax), fullyQualifiedName: "stripe.customer.CustomerTax")]
        internal sealed class _Proxy : DeputyBase, stripe.Customer.ICustomerTax
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#ip_address Customer#ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A flag that indicates when Stripe should validate the customer tax location. Defaults to `deferred`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#validate_location Customer#validate_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validateLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidateLocation
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
