using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle")]
    public class DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle : oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundle
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#type DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>certificate_private_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#certificate_private_key DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#certificate_private_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePrivateKey", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey\"}", isOptional: true)]
        public oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePrivateKey? CertificatePrivateKey
        {
            get;
            set;
        }

        /// <summary>certificate_public block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/database_tools_runtime_database_tools_database_api_gateway_config_global#certificate_public DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal#certificate_public}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "certificatePublic", typeJson: "{\"fqn\":\"oci.databaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublic\"}", isOptional: true)]
        public oci.DatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobal.IDatabaseToolsRuntimeDatabaseToolsDatabaseApiGatewayConfigGlobalCertificateBundleCertificatePublic? CertificatePublic
        {
            get;
            set;
        }
    }
}
