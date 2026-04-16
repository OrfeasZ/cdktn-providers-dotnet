using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerShippingAddress), fullyQualifiedName: "stripe.customer.CustomerShippingAddress")]
    public interface ICustomerShippingAddress
    {
        /// <summary>City, district, suburb, town, or village.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#city Customer#city}
        /// </remarks>
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? City
        {
            get
            {
                return null;
            }
        }

        /// <summary>A freeform text field for the country.</summary>
        /// <remarks>
        /// However, in order to activate some tax features, the format should be a two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a>).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#country Customer#country}
        /// </remarks>
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Country
        {
            get
            {
                return null;
            }
        }

        /// <summary>Address line 1, such as the street, PO Box, or company name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#line1 Customer#line1}
        /// </remarks>
        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Line1
        {
            get
            {
                return null;
            }
        }

        /// <summary>Address line 2, such as the apartment, suite, unit, or building.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#line2 Customer#line2}
        /// </remarks>
        [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Line2
        {
            get
            {
                return null;
            }
        }

        /// <summary>ZIP or postal code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#postal_code Customer#postal_code}
        /// </remarks>
        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostalCode
        {
            get
            {
                return null;
            }
        }

        /// <summary>State, county, province, or region.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#state Customer#state}
        /// </remarks>
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? State
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerShippingAddress), fullyQualifiedName: "stripe.customer.CustomerShippingAddress")]
        internal sealed class _Proxy : DeputyBase, stripe.Customer.ICustomerShippingAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>City, district, suburb, town, or village.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#city Customer#city}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? City
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A freeform text field for the country.</summary>
            /// <remarks>
            /// However, in order to activate some tax features, the format should be a two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a>).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#country Customer#country}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Address line 1, such as the street, PO Box, or company name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#line1 Customer#line1}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Line1
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Address line 2, such as the apartment, suite, unit, or building.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#line2 Customer#line2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Line2
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ZIP or postal code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#postal_code Customer#postal_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostalCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>State, county, province, or region.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#state Customer#state}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? State
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
