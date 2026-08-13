using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.TerminalLocation
{
    [JsiiByValue(fqn: "stripe.terminalLocation.TerminalLocationAddressKana")]
    public class TerminalLocationAddressKana : stripe.TerminalLocation.ITerminalLocationAddressKana
    {
        /// <summary>City/Ward.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_location#city TerminalLocation#city}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "city", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? City
        {
            get;
            set;
        }

        /// <summary>Two-letter country code ([ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_location#country TerminalLocation#country}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "country", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Country
        {
            get;
            set;
        }

        /// <summary>Block/Building number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_location#line1 TerminalLocation#line1}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "line1", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Line1
        {
            get;
            set;
        }

        /// <summary>Building details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_location#line2 TerminalLocation#line2}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "line2", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Line2
        {
            get;
            set;
        }

        /// <summary>ZIP or postal code.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_location#postal_code TerminalLocation#postal_code}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postalCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PostalCode
        {
            get;
            set;
        }

        /// <summary>Prefecture.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_location#state TerminalLocation#state}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? State
        {
            get;
            set;
        }

        /// <summary>Town/cho-me.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/terminal_location#town TerminalLocation#town}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "town", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Town
        {
            get;
            set;
        }
    }
}
