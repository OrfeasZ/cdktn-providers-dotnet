using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources
{
    [JsiiInterface(nativeType: typeof(IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter), fullyQualifiedName: "oci.dataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter")]
    public interface IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources#name DataOciFleetAppsManagementSchedulerJobJobActivityResources#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources#values DataOciFleetAppsManagementSchedulerJobJobActivityResources#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources#regex DataOciFleetAppsManagementSchedulerJobJobActivityResources#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter), fullyQualifiedName: "oci.dataOciFleetAppsManagementSchedulerJobJobActivityResources.DataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciFleetAppsManagementSchedulerJobJobActivityResources.IDataOciFleetAppsManagementSchedulerJobJobActivityResourcesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources#name DataOciFleetAppsManagementSchedulerJobJobActivityResources#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources#values DataOciFleetAppsManagementSchedulerJobJobActivityResources#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_resources#regex DataOciFleetAppsManagementSchedulerJobJobActivityResources#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
