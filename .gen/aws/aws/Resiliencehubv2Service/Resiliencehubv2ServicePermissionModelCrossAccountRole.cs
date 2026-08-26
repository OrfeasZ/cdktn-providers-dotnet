using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Resiliencehubv2Service
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.resiliencehubv2Service.Resiliencehubv2ServicePermissionModelCrossAccountRole")]
    public class Resiliencehubv2ServicePermissionModelCrossAccountRole : aws.Resiliencehubv2Service.IResiliencehubv2ServicePermissionModelCrossAccountRole
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_service#cross_account_role_arn Resiliencehubv2Service#cross_account_role_arn}.</summary>
        [JsiiProperty(name: "crossAccountRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CrossAccountRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.62.0/docs/resources/resiliencehubv2_service#external_id Resiliencehubv2Service#external_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalId
        {
            get;
            set;
        }
    }
}
