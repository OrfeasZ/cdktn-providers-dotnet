using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabaseSaasAdminUser
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseSaasAdminUserTimeouts), fullyQualifiedName: "oci.databaseAutonomousDatabaseSaasAdminUser.DatabaseAutonomousDatabaseSaasAdminUserTimeouts")]
    public interface IDatabaseAutonomousDatabaseSaasAdminUserTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#create DatabaseAutonomousDatabaseSaasAdminUser#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#delete DatabaseAutonomousDatabaseSaasAdminUser#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#update DatabaseAutonomousDatabaseSaasAdminUser#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseSaasAdminUserTimeouts), fullyQualifiedName: "oci.databaseAutonomousDatabaseSaasAdminUser.DatabaseAutonomousDatabaseSaasAdminUserTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabaseSaasAdminUser.IDatabaseAutonomousDatabaseSaasAdminUserTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#create DatabaseAutonomousDatabaseSaasAdminUser#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#delete DatabaseAutonomousDatabaseSaasAdminUser#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database_saas_admin_user#update DatabaseAutonomousDatabaseSaasAdminUser#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
