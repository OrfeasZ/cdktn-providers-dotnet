using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableViewDefinitionRepresentations), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentations")]
    public interface IGlueCatalogTableViewDefinitionRepresentations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#dialect GlueCatalogTable#dialect}.</summary>
        [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Dialect
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#dialect_version GlueCatalogTable#dialect_version}.</summary>
        [JsiiProperty(name: "dialectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DialectVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#validation_connection GlueCatalogTable#validation_connection}.</summary>
        [JsiiProperty(name: "validationConnection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidationConnection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_expanded_text GlueCatalogTable#view_expanded_text}.</summary>
        [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ViewExpandedText
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_original_text GlueCatalogTable#view_original_text}.</summary>
        [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ViewOriginalText
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableViewDefinitionRepresentations), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentations")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableViewDefinitionRepresentations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#dialect GlueCatalogTable#dialect}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dialect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Dialect
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#dialect_version GlueCatalogTable#dialect_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dialectVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DialectVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#validation_connection GlueCatalogTable#validation_connection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "validationConnection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidationConnection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_expanded_text GlueCatalogTable#view_expanded_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "viewExpandedText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ViewExpandedText
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_original_text GlueCatalogTable#view_original_text}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "viewOriginalText", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ViewOriginalText
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
