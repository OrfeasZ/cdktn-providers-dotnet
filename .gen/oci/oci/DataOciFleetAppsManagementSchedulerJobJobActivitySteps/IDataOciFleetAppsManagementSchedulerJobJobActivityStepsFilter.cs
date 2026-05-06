using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementSchedulerJobJobActivitySteps
{
    [JsiiInterface(nativeType: typeof(IDataOciFleetAppsManagementSchedulerJobJobActivityStepsFilter), fullyQualifiedName: "oci.dataOciFleetAppsManagementSchedulerJobJobActivitySteps.DataOciFleetAppsManagementSchedulerJobJobActivityStepsFilter")]
    public interface IDataOciFleetAppsManagementSchedulerJobJobActivityStepsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#name DataOciFleetAppsManagementSchedulerJobJobActivitySteps#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#values DataOciFleetAppsManagementSchedulerJobJobActivitySteps#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#regex DataOciFleetAppsManagementSchedulerJobJobActivitySteps#regex}.</summary>
        [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Regex
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciFleetAppsManagementSchedulerJobJobActivityStepsFilter), fullyQualifiedName: "oci.dataOciFleetAppsManagementSchedulerJobJobActivitySteps.DataOciFleetAppsManagementSchedulerJobJobActivityStepsFilter")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciFleetAppsManagementSchedulerJobJobActivitySteps.IDataOciFleetAppsManagementSchedulerJobJobActivityStepsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#name DataOciFleetAppsManagementSchedulerJobJobActivitySteps#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#values DataOciFleetAppsManagementSchedulerJobJobActivitySteps#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/data-sources/fleet_apps_management_scheduler_job_job_activity_steps#regex DataOciFleetAppsManagementSchedulerJobJobActivitySteps#regex}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regex", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Regex
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
