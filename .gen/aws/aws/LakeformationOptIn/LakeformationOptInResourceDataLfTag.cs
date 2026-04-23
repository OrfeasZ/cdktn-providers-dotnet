using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationOptIn
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lakeformationOptIn.LakeformationOptInResourceDataLfTag")]
    public class LakeformationOptInResourceDataLfTag : aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTag
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lakeformation_opt_in#key LakeformationOptIn#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lakeformation_opt_in#values LakeformationOptIn#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/lakeformation_opt_in#catalog_id LakeformationOptIn#catalog_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CatalogId
        {
            get;
            set;
        }
    }
}
