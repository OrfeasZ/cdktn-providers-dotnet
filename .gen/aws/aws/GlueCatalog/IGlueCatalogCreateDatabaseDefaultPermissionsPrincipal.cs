using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueCatalog
{
    [JsiiInterface(nativeType: typeof(IGlueCatalogCreateDatabaseDefaultPermissionsPrincipal), fullyQualifiedName: "aws.glueCatalog.GlueCatalogCreateDatabaseDefaultPermissionsPrincipal")]
    public interface IGlueCatalogCreateDatabaseDefaultPermissionsPrincipal
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#data_lake_principal_identifier GlueCatalog#data_lake_principal_identifier}.</summary>
        [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataLakePrincipalIdentifier
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueCatalogCreateDatabaseDefaultPermissionsPrincipal), fullyQualifiedName: "aws.glueCatalog.GlueCatalogCreateDatabaseDefaultPermissionsPrincipal")]
        internal sealed class _Proxy : DeputyBase, aws.GlueCatalog.IGlueCatalogCreateDatabaseDefaultPermissionsPrincipal
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_catalog#data_lake_principal_identifier GlueCatalog#data_lake_principal_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataLakePrincipalIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataLakePrincipalIdentifier
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
