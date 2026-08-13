using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiByValue(fqn: "stripe.person.PersonUsCfpbDataRaceDetails")]
    public class PersonUsCfpbDataRaceDetails : stripe.Person.IPersonUsCfpbDataRaceDetails
    {
        /// <summary>The persons race.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race Person#race}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "race", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Race
        {
            get;
            set;
        }

        /// <summary>Please specify your race, when other is selected.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race_other Person#race_other}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "raceOther", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RaceOther
        {
            get;
            set;
        }
    }
}
