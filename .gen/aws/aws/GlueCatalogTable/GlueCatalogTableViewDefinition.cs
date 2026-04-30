using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalogTable
{
    [JsiiByValue(fqn: "aws.glueCatalogTable.GlueCatalogTableViewDefinition")]
    public class GlueCatalogTableViewDefinition : aws.GlueCatalogTable.IGlueCatalogTableViewDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#definer GlueCatalogTable#definer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Definer
        {
            get;
            set;
        }

        private object? _isProtected;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#is_protected GlueCatalogTable#is_protected}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isProtected", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsProtected
        {
            get => _isProtected;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isProtected = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#last_refresh_type GlueCatalogTable#last_refresh_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lastRefreshType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LastRefreshType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#refresh_seconds GlueCatalogTable#refresh_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "refreshSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RefreshSeconds
        {
            get;
            set;
        }

        private object? _representations;

        /// <summary>representations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#representations GlueCatalogTable#representations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "representations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalogTable.GlueCatalogTableViewDefinitionRepresentations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Representations
        {
            get => _representations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.GlueCatalogTable.IGlueCatalogTableViewDefinitionRepresentations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalogTable.IGlueCatalogTableViewDefinitionRepresentations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _representations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#sub_objects GlueCatalogTable#sub_objects}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subObjects", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubObjects
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#sub_object_version_ids GlueCatalogTable#sub_object_version_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subObjectVersionIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? SubObjectVersionIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_version_id GlueCatalogTable#view_version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "viewVersionId", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ViewVersionId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/glue_catalog_table#view_version_token GlueCatalogTable#view_version_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "viewVersionToken", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ViewVersionToken
        {
            get;
            set;
        }
    }
}
