using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Policy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubv2Policy.Resiliencehubv2PolicyMultiAz")]
    public class Resiliencehubv2PolicyMultiAz : aws.Resiliencehubv2Policy.IResiliencehubv2PolicyMultiAz
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/resiliencehubv2_policy#disaster_recovery_approach Resiliencehubv2Policy#disaster_recovery_approach}.</summary>
        [JsiiProperty(name: "disasterRecoveryApproach", typeJson: "{\"primitive\":\"string\"}")]
        public string DisasterRecoveryApproach
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/resiliencehubv2_policy#rpo_in_minutes Resiliencehubv2Policy#rpo_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rpoInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RpoInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/resiliencehubv2_policy#rto_in_minutes Resiliencehubv2Policy#rto_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rtoInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RtoInMinutes
        {
            get;
            set;
        }
    }
}
