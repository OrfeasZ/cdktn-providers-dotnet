using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiByValue(fqn: "aws.glueCatalog.GlueCatalogCreateDatabaseDefaultPermissionsPrincipal")]
    public class GlueCatalogCreateDatabaseDefaultPermissionsPrincipal : aws.GlueCatalog.IGlueCatalogCreateDatabaseDefaultPermissionsPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_lake_principal_identifier GlueCatalog#data_lake_principal_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataLakePrincipalIdentifier
        {
            get;
            set;
        }
    }
}
