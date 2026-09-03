using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Service
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubv2Service.Resiliencehubv2ServiceAssociatedSystem")]
    public class Resiliencehubv2ServiceAssociatedSystem : aws.Resiliencehubv2Service.IResiliencehubv2ServiceAssociatedSystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#system_arn Resiliencehubv2Service#system_arn}.</summary>
        [JsiiProperty(name: "systemArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SystemArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/resiliencehubv2_service#user_journey_ids Resiliencehubv2Service#user_journey_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userJourneyIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UserJourneyIds
        {
            get;
            set;
        }
    }
}
