using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiByValue(fqn: "stripe.customer.CustomerTax")]
    public class CustomerTax : stripe.Customer.ICustomerTax
    {
        /// <summary>A recent IP address of the customer used for tax reporting and tax location inference.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#ip_address Customer#ip_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddress
        {
            get;
            set;
        }

        private object? _location;

        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#location Customer#location}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.Customer.ICustomerTaxLocation" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.customer.CustomerTaxLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Location
        {
            get => _location;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case stripe.Customer.ICustomerTaxLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(stripe.Customer.ICustomerTaxLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _location = value;
            }
        }

        /// <summary>A flag that indicates when Stripe should validate the customer tax location. Defaults to `deferred`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/customer#validate_location Customer#validate_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validateLocation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ValidateLocation
        {
            get;
            set;
        }
    }
}
