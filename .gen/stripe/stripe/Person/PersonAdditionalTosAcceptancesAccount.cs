using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiByValue(fqn: "stripe.person.PersonAdditionalTosAcceptancesAccount")]
    public class PersonAdditionalTosAcceptancesAccount : stripe.Person.IPersonAdditionalTosAcceptancesAccount
    {
        /// <summary>The Unix timestamp marking when the legal guardian accepted the service agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#date Person#date}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Date
        {
            get;
            set;
        }

        /// <summary>The IP address from which the legal guardian accepted the service agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ip Person#ip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ip
        {
            get;
            set;
        }

        /// <summary>The user agent of the browser from which the legal guardian accepted the service agreement.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#user_agent Person#user_agent}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserAgent
        {
            get;
            set;
        }
    }
}
