using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogTableViewDefinition), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableViewDefinition")]
    public interface IGlueCatalogTableViewDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#definer GlueCatalogTable#definer}.</summary>
        [JsiiProperty(name: "definer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Definer
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#is_protected GlueCatalogTable#is_protected}.</summary>
        [JsiiProperty(name: "isProtected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsProtected
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#last_refresh_type GlueCatalogTable#last_refresh_type}.</summary>
        [JsiiProperty(name: "lastRefreshType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastRefreshType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#refresh_seconds GlueCatalogTable#refresh_seconds}.</summary>
        [JsiiProperty(name: "refreshSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RefreshSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>representations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#representations GlueCatalogTable#representations}
        /// </remarks>
        [JsiiProperty(name: "representations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Representations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#sub_objects GlueCatalogTable#sub_objects}.</summary>
        [JsiiProperty(name: "subObjects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SubObjects
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#sub_object_version_ids GlueCatalogTable#sub_object_version_ids}.</summary>
        [JsiiProperty(name: "subObjectVersionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? SubObjectVersionIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_version_id GlueCatalogTable#view_version_id}.</summary>
        [JsiiProperty(name: "viewVersionId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ViewVersionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_version_token GlueCatalogTable#view_version_token}.</summary>
        [JsiiProperty(name: "viewVersionToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ViewVersionToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogTableViewDefinition), fullyQualifiedName: "aws.glueCatalogTable.GlueCatalogTableViewDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalogTable.IGlueCatalogTableViewDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#definer GlueCatalogTable#definer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Definer
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#is_protected GlueCatalogTable#is_protected}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isProtected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsProtected
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#last_refresh_type GlueCatalogTable#last_refresh_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastRefreshType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastRefreshType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#refresh_seconds GlueCatalogTable#refresh_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "refreshSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RefreshSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>representations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#representations GlueCatalogTable#representations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "representations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Representations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#sub_objects GlueCatalogTable#sub_objects}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subObjects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SubObjects
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#sub_object_version_ids GlueCatalogTable#sub_object_version_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subObjectVersionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? SubObjectVersionIds
            {
                get => GetInstanceProperty<double[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_version_id GlueCatalogTable#view_version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "viewVersionId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ViewVersionId
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_version_token GlueCatalogTable#view_version_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "viewVersionToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ViewVersionToken
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
