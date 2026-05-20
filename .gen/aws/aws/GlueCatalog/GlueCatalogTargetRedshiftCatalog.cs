using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueCatalog.GlueCatalogTargetRedshiftCatalog")]
    public class GlueCatalogTargetRedshiftCatalog : aws.GlueCatalog.IGlueCatalogTargetRedshiftCatalog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/glue_catalog#catalog_arn GlueCatalog#catalog_arn}.</summary>
        [JsiiProperty(name: "catalogArn", typeJson: "{\"primitive\":\"string\"}")]
        public string CatalogArn
        {
            get;
            set;
        }
    }
}
