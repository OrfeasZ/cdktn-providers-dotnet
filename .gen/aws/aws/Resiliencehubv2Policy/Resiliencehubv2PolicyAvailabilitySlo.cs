using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Policy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubv2Policy.Resiliencehubv2PolicyAvailabilitySlo")]
    public class Resiliencehubv2PolicyAvailabilitySlo : aws.Resiliencehubv2Policy.IResiliencehubv2PolicyAvailabilitySlo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/resiliencehubv2_policy#target Resiliencehubv2Policy#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"number\"}")]
        public double Target
        {
            get;
            set;
        }
    }
}
