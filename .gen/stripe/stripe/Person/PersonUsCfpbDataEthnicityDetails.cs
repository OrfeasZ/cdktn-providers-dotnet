using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiByValue(fqn: "stripe.person.PersonUsCfpbDataEthnicityDetails")]
    public class PersonUsCfpbDataEthnicityDetails : stripe.Person.IPersonUsCfpbDataEthnicityDetails
    {
        /// <summary>The persons ethnicity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity Person#ethnicity}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ethnicity", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Ethnicity
        {
            get;
            set;
        }

        /// <summary>Please specify your origin, when other is selected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity_other Person#ethnicity_other}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ethnicityOther", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EthnicityOther
        {
            get;
            set;
        }
    }
}
