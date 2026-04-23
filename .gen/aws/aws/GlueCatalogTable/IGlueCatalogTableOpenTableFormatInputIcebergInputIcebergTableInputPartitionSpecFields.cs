using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields")]
    public interface IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#name GlueCatalogTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#source_id GlueCatalogTable#source_id}.</summary>
        [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"number\"}")]
        double SourceId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#transform GlueCatalogTable#transform}.</summary>
        [JsiiProperty(name: "transform", typeJson: "{\"primitive\":\"string\"}")]
        string Transform
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#field_id GlueCatalogTable#field_id}.</summary>
        [JsiiProperty(name: "fieldId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FieldId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableOpenTableFormatInputIcebergInputIcebergTableInputPartitionSpecFields
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#name GlueCatalogTable#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#source_id GlueCatalogTable#source_id}.</summary>
            [JsiiProperty(name: "sourceId", typeJson: "{\"primitive\":\"number\"}")]
            public double SourceId
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#transform GlueCatalogTable#transform}.</summary>
            [JsiiProperty(name: "transform", typeJson: "{\"primitive\":\"string\"}")]
            public string Transform
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/glue_catalog_table#field_id GlueCatalogTable#field_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fieldId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FieldId
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
