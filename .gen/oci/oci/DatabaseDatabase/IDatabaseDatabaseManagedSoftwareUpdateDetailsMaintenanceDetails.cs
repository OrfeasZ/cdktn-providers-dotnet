using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails")]
    public interface IDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#time_of_last_readiness_check DatabaseDatabase#time_of_last_readiness_check}.</summary>
        [JsiiProperty(name: "timeOfLastReadinessCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeOfLastReadinessCheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#time_of_status_update DatabaseDatabase#time_of_status_update}.</summary>
        [JsiiProperty(name: "timeOfStatusUpdate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeOfStatusUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#time_scheduled DatabaseDatabase#time_scheduled}.</summary>
        [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeScheduled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#update_mode DatabaseDatabase#update_mode}.</summary>
        [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#update_readiness_status DatabaseDatabase#update_readiness_status}.</summary>
        [JsiiProperty(name: "updateReadinessStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateReadinessStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#update_readiness_status_details DatabaseDatabase#update_readiness_status_details}.</summary>
        [JsiiProperty(name: "updateReadinessStatusDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdateReadinessStatusDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#version DatabaseDatabase#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails), fullyQualifiedName: "oci.databaseDatabase.DatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDatabase.IDatabaseDatabaseManagedSoftwareUpdateDetailsMaintenanceDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#time_of_last_readiness_check DatabaseDatabase#time_of_last_readiness_check}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeOfLastReadinessCheck", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeOfLastReadinessCheck
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#time_of_status_update DatabaseDatabase#time_of_status_update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeOfStatusUpdate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeOfStatusUpdate
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#time_scheduled DatabaseDatabase#time_scheduled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeScheduled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeScheduled
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#update_mode DatabaseDatabase#update_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#update_readiness_status DatabaseDatabase#update_readiness_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateReadinessStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateReadinessStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#update_readiness_status_details DatabaseDatabase#update_readiness_status_details}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updateReadinessStatusDetails", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdateReadinessStatusDetails
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.24.0/docs/resources/database_database#version DatabaseDatabase#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
