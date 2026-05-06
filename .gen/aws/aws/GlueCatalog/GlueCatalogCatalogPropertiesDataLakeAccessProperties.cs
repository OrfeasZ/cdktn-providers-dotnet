using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiByValue(fqn: "aws.glueCatalog.GlueCatalogCatalogPropertiesDataLakeAccessProperties")]
    public class GlueCatalogCatalogPropertiesDataLakeAccessProperties : aws.GlueCatalog.IGlueCatalogCatalogPropertiesDataLakeAccessProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#catalog_type GlueCatalog#catalog_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "catalogType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CatalogType
        {
            get;
            set;
        }

        private object? _dataLakeAccess;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_lake_access GlueCatalog#data_lake_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataLakeAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? DataLakeAccess
        {
            get => _dataLakeAccess;
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
                _dataLakeAccess = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_transfer_role GlueCatalog#data_transfer_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataTransferRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataTransferRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#kms_key GlueCatalog#kms_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKey
        {
            get;
            set;
        }
    }
}
