using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationLfTagExpression
{
    [JsiiInterface(nativeType: typeof(ILakeformationLfTagExpressionExpression), fullyQualifiedName: "aws.lakeformationLfTagExpression.LakeformationLfTagExpressionExpression")]
    public interface ILakeformationLfTagExpressionExpression
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lakeformation_lf_tag_expression#tag_key LakeformationLfTagExpression#tag_key}.</summary>
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
        string TagKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lakeformation_lf_tag_expression#tag_values LakeformationLfTagExpression#tag_values}.</summary>
        [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TagValues
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILakeformationLfTagExpressionExpression), fullyQualifiedName: "aws.lakeformationLfTagExpression.LakeformationLfTagExpressionExpression")]
        internal sealed class _Proxy : DeputyBase, aws.LakeformationLfTagExpression.ILakeformationLfTagExpressionExpression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lakeformation_lf_tag_expression#tag_key LakeformationLfTagExpression#tag_key}.</summary>
            [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}")]
            public string TagKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lakeformation_lf_tag_expression#tag_values LakeformationLfTagExpression#tag_values}.</summary>
            [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TagValues
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
