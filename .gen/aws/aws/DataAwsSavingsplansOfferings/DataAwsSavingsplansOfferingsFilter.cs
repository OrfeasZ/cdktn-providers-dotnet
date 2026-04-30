using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSavingsplansOfferings
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsSavingsplansOfferings.DataAwsSavingsplansOfferingsFilter")]
    public class DataAwsSavingsplansOfferingsFilter : aws.DataAwsSavingsplansOfferings.IDataAwsSavingsplansOfferingsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/savingsplans_offerings#name DataAwsSavingsplansOfferings#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/savingsplans_offerings#values DataAwsSavingsplansOfferings#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
