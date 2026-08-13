using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.person.PersonDob")]
    public class PersonDob : stripe.Person.IPersonDob
    {
        /// <summary>The day of birth, between 1 and 31.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#day Person#day}
        /// </remarks>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"number\"}")]
        public double Day
        {
            get;
            set;
        }

        /// <summary>The month of birth, between 1 and 12.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#month Person#month}
        /// </remarks>
        [JsiiProperty(name: "month", typeJson: "{\"primitive\":\"number\"}")]
        public double Month
        {
            get;
            set;
        }

        /// <summary>The four-digit year of birth.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#year Person#year}
        /// </remarks>
        [JsiiProperty(name: "year", typeJson: "{\"primitive\":\"number\"}")]
        public double Year
        {
            get;
            set;
        }
    }
}
