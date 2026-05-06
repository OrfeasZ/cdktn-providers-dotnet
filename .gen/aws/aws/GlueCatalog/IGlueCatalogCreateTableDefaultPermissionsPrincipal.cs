using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogCreateTableDefaultPermissionsPrincipal), fullyQualifiedName: "aws.glueCatalog.GlueCatalogCreateTableDefaultPermissionsPrincipal")]
    public interface IGlueCatalogCreateTableDefaultPermissionsPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_lake_principal_identifier GlueCatalog#data_lake_principal_identifier}.</summary>
        [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataLakePrincipalIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogCreateTableDefaultPermissionsPrincipal), fullyQualifiedName: "aws.glueCatalog.GlueCatalogCreateTableDefaultPermissionsPrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalog.IGlueCatalogCreateTableDefaultPermissionsPrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_catalog#data_lake_principal_identifier GlueCatalog#data_lake_principal_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataLakePrincipalIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
