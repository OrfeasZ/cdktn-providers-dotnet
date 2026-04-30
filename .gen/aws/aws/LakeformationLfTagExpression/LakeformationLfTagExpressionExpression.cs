using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationLfTagExpression
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lakeformationLfTagExpression.LakeformationLfTagExpressionExpression")]
    public class LakeformationLfTagExpressionExpression : aws.LakeformationLfTagExpression.ILakeformationLfTagExpressionExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lakeformation_lf_tag_expression#tag_key LakeformationLfTagExpression#tag_key}.</summary>
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
        public string TagKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lakeformation_lf_tag_expression#tag_values LakeformationLfTagExpression#tag_values}.</summary>
        [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TagValues
        {
            get;
            set;
        }
    }
}
