using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiByValue(fqn: "aws.glueCatalog.GlueCatalogFederatedCatalog")]
    public class GlueCatalogFederatedCatalog : aws.GlueCatalog.IGlueCatalogFederatedCatalog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#connection_name GlueCatalog#connection_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#connection_type GlueCatalog#connection_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConnectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#identifier GlueCatalog#identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identifier
        {
            get;
            set;
        }
    }
}
