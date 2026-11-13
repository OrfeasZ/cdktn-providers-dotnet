using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress")]
    public interface IThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress
    {
        /// <summary>City, district, suburb, town, or village.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#city ThreeDSecureAuthentication#city}
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

        /// <summary>Two-letter country code ([ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#country ThreeDSecureAuthentication#country}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#line1 ThreeDSecureAuthentication#line1}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#line2 ThreeDSecureAuthentication#line2}
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#postal_code ThreeDSecureAuthentication#postal_code}
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

        /// <summary>Country subdivision code defined in ISO 3166-2.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#state ThreeDSecureAuthentication#state}
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

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>City, district, suburb, town, or village.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#city ThreeDSecureAuthentication#city}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? City
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Two-letter country code ([ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#country ThreeDSecureAuthentication#country}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Country
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Address line 1, such as the street, PO Box, or company name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#line1 ThreeDSecureAuthentication#line1}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Line1
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Address line 2, such as the apartment, suite, unit, or building.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#line2 ThreeDSecureAuthentication#line2}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Line2
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ZIP or postal code.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#postal_code ThreeDSecureAuthentication#postal_code}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostalCode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Country subdivision code defined in ISO 3166-2.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#state ThreeDSecureAuthentication#state}
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
