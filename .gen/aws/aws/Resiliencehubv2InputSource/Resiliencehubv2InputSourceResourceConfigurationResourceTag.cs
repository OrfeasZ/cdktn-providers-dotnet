using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2InputSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubv2InputSource.Resiliencehubv2InputSourceResourceConfigurationResourceTag")]
    public class Resiliencehubv2InputSourceResourceConfigurationResourceTag : aws.Resiliencehubv2InputSource.IResiliencehubv2InputSourceResourceConfigurationResourceTag
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_input_source#key Resiliencehubv2InputSource#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_input_source#values Resiliencehubv2InputSource#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
