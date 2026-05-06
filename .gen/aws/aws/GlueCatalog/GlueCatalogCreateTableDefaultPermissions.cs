using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiByValue(fqn: "aws.glueCatalog.GlueCatalogCreateTableDefaultPermissions")]
    public class GlueCatalogCreateTableDefaultPermissions : aws.GlueCatalog.IGlueCatalogCreateTableDefaultPermissions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#permissions GlueCatalog#permissions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Permissions
        {
            get;
            set;
        }

        private object? _principal;

        /// <summary>principal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#principal GlueCatalog#principal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "principal", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.glueCatalog.GlueCatalogCreateTableDefaultPermissionsPrincipal\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Principal
        {
            get => _principal;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.GlueCatalog.IGlueCatalogCreateTableDefaultPermissionsPrincipal[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.GlueCatalog.IGlueCatalogCreateTableDefaultPermissionsPrincipal).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principal = value;
            }
        }
    }
}
