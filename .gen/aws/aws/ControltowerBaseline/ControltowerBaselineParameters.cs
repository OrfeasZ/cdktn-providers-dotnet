using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ControltowerBaseline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.controltowerBaseline.ControltowerBaselineParameters")]
    public class ControltowerBaselineParameters : aws.ControltowerBaseline.IControltowerBaselineParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/controltower_baseline#key ControltowerBaseline#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/controltower_baseline#value ControltowerBaseline#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
