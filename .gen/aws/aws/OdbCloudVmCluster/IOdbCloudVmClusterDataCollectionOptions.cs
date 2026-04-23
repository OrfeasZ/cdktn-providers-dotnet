using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbCloudVmCluster
{
    [JsiiInterface(nativeType: typeof(IOdbCloudVmClusterDataCollectionOptions), fullyQualifiedName: "aws.odbCloudVmCluster.OdbCloudVmClusterDataCollectionOptions")]
    public interface IOdbCloudVmClusterDataCollectionOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_vm_cluster#is_diagnostics_events_enabled OdbCloudVmCluster#is_diagnostics_events_enabled}.</summary>
        [JsiiProperty(name: "isDiagnosticsEventsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsDiagnosticsEventsEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_vm_cluster#is_health_monitoring_enabled OdbCloudVmCluster#is_health_monitoring_enabled}.</summary>
        [JsiiProperty(name: "isHealthMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsHealthMonitoringEnabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_vm_cluster#is_incident_logs_enabled OdbCloudVmCluster#is_incident_logs_enabled}.</summary>
        [JsiiProperty(name: "isIncidentLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IsIncidentLogsEnabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbCloudVmClusterDataCollectionOptions), fullyQualifiedName: "aws.odbCloudVmCluster.OdbCloudVmClusterDataCollectionOptions")]
        internal sealed class _Proxy : DeputyBase, aws.OdbCloudVmCluster.IOdbCloudVmClusterDataCollectionOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_vm_cluster#is_diagnostics_events_enabled OdbCloudVmCluster#is_diagnostics_events_enabled}.</summary>
            [JsiiProperty(name: "isDiagnosticsEventsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsDiagnosticsEventsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_vm_cluster#is_health_monitoring_enabled OdbCloudVmCluster#is_health_monitoring_enabled}.</summary>
            [JsiiProperty(name: "isHealthMonitoringEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsHealthMonitoringEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/odb_cloud_vm_cluster#is_incident_logs_enabled OdbCloudVmCluster#is_incident_logs_enabled}.</summary>
            [JsiiProperty(name: "isIncidentLogsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IsIncidentLogsEnabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
