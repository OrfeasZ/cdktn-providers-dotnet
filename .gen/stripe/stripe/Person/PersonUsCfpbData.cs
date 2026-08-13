using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiByValue(fqn: "stripe.person.PersonUsCfpbData")]
    public class PersonUsCfpbData : stripe.Person.IPersonUsCfpbData
    {
        /// <summary>The persons ethnicity details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#ethnicity_details Person#ethnicity_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ethnicityDetails", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataEthnicityDetails\"}", isOptional: true)]
        public stripe.Person.IPersonUsCfpbDataEthnicityDetails? EthnicityDetails
        {
            get;
            set;
        }

        /// <summary>The persons race details.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#race_details Person#race_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "raceDetails", typeJson: "{\"fqn\":\"stripe.person.PersonUsCfpbDataRaceDetails\"}", isOptional: true)]
        public stripe.Person.IPersonUsCfpbDataRaceDetails? RaceDetails
        {
            get;
            set;
        }

        /// <summary>The persons self-identified gender.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/person#self_identified_gender Person#self_identified_gender}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selfIdentifiedGender", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SelfIdentifiedGender
        {
            get;
            set;
        }
    }
}
