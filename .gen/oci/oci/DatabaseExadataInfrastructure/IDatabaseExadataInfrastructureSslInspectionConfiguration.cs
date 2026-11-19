using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseExadataInfrastructure
{
    [JsiiInterface(nativeType: typeof(IDatabaseExadataInfrastructureSslInspectionConfiguration), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureSslInspectionConfiguration")]
    public interface IDatabaseExadataInfrastructureSslInspectionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_exadata_infrastructure#is_enabled DatabaseExadataInfrastructure#is_enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_exadata_infrastructure#certificate_authority_id DatabaseExadataInfrastructure#certificate_authority_id}.</summary>
        [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateAuthorityId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseExadataInfrastructureSslInspectionConfiguration), fullyQualifiedName: "oci.databaseExadataInfrastructure.DatabaseExadataInfrastructureSslInspectionConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseExadataInfrastructure.IDatabaseExadataInfrastructureSslInspectionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_exadata_infrastructure#is_enabled DatabaseExadataInfrastructure#is_enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.14.0/docs/resources/database_exadata_infrastructure#certificate_authority_id DatabaseExadataInfrastructure#certificate_authority_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateAuthorityId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateAuthorityId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
