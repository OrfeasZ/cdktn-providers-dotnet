using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseDataGuardAssociation
{
    [JsiiInterface(nativeType: typeof(IDatabaseDataGuardAssociationDataCollectionOptions), fullyQualifiedName: "oci.databaseDataGuardAssociation.DatabaseDataGuardAssociationDataCollectionOptions")]
    public interface IDatabaseDataGuardAssociationDataCollectionOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#is_diagnostics_events_enabled DatabaseDataGuardAssociation#is_diagnostics_events_enabled}.</summary>
        [JsiiProperty(name: "isDiagnosticsEventsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsDiagnosticsEventsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#is_health_monitoring_enabled DatabaseDataGuardAssociation#is_health_monitoring_enabled}.</summary>
        [JsiiProperty(name: "isHealthMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsHealthMonitoringEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#is_incident_logs_enabled DatabaseDataGuardAssociation#is_incident_logs_enabled}.</summary>
        [JsiiProperty(name: "isIncidentLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsIncidentLogsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseDataGuardAssociationDataCollectionOptions), fullyQualifiedName: "oci.databaseDataGuardAssociation.DatabaseDataGuardAssociationDataCollectionOptions")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseDataGuardAssociation.IDatabaseDataGuardAssociationDataCollectionOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#is_diagnostics_events_enabled DatabaseDataGuardAssociation#is_diagnostics_events_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isDiagnosticsEventsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsDiagnosticsEventsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#is_health_monitoring_enabled DatabaseDataGuardAssociation#is_health_monitoring_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isHealthMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsHealthMonitoringEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_data_guard_association#is_incident_logs_enabled DatabaseDataGuardAssociation#is_incident_logs_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isIncidentLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsIncidentLogsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
