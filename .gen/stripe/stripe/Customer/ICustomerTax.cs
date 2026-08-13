using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerTax), fullyQualifiedName: "stripe.customer.CustomerTax")]
    public interface ICustomerTax
    {
        /// <summary>A recent IP address of the customer used for tax reporting and tax location inference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#ip_address Customer#ip_address}
        /// </remarks>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddress
        {
            get
            {
                return null;
            }
        }

        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#location Customer#location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerTaxLocation" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerTaxLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Location
        {
            get
            {
                return null;
            }
        }

        /// <summary>A flag that indicates when Stripe should validate the customer tax location. Defaults to `deferred`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#validate_location Customer#validate_location}
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

            /// <summary>A recent IP address of the customer used for tax reporting and tax location inference.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#ip_address Customer#ip_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddress
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#location Customer#location}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerTaxLocation" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerTaxLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Location
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>A flag that indicates when Stripe should validate the customer tax location. Defaults to `deferred`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#validate_location Customer#validate_location}
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
