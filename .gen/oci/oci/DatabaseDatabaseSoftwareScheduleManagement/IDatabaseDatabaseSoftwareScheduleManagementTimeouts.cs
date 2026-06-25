using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabaseSoftwareScheduleManagement
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseSoftwareScheduleManagementTimeouts), fullyQualifiedName: "oci.databaseDatabaseSoftwareScheduleManagement.DatabaseDatabaseSoftwareScheduleManagementTimeouts")]
    public interface IDatabaseDatabaseSoftwareScheduleManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_database_software_schedule_management#create DatabaseDatabaseSoftwareScheduleManagement#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_database_software_schedule_management#delete DatabaseDatabaseSoftwareScheduleManagement#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_database_software_schedule_management#update DatabaseDatabaseSoftwareScheduleManagement#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseSoftwareScheduleManagementTimeouts), fullyQualifiedName: "oci.databaseDatabaseSoftwareScheduleManagement.DatabaseDatabaseSoftwareScheduleManagementTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabaseSoftwareScheduleManagement.IDatabaseDatabaseSoftwareScheduleManagementTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_database_software_schedule_management#create DatabaseDatabaseSoftwareScheduleManagement#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_database_software_schedule_management#delete DatabaseDatabaseSoftwareScheduleManagement#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/database_database_software_schedule_management#update DatabaseDatabaseSoftwareScheduleManagement#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
