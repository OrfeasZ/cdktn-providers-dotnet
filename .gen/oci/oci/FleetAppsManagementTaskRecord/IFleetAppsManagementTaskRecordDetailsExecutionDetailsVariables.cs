using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FleetAppsManagementTaskRecord
{
    [JsiiInterface(nativeType: typeof(IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables), fullyQualifiedName: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariables")]
    public interface IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables
    {
        /// <summary>input_variables block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#input_variables FleetAppsManagementTaskRecord#input_variables}
        /// </remarks>
        [JsiiProperty(name: "inputVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesInputVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? InputVariables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#output_variables FleetAppsManagementTaskRecord#output_variables}.</summary>
        [JsiiProperty(name: "outputVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OutputVariables
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables), fullyQualifiedName: "oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariables")]
        internal sealed class _Proxy : DeputyBase, oci.FleetAppsManagementTaskRecord.IFleetAppsManagementTaskRecordDetailsExecutionDetailsVariables
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>input_variables block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#input_variables FleetAppsManagementTaskRecord#input_variables}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputVariables", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.fleetAppsManagementTaskRecord.FleetAppsManagementTaskRecordDetailsExecutionDetailsVariablesInputVariables\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? InputVariables
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/fleet_apps_management_task_record#output_variables FleetAppsManagementTaskRecord#output_variables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outputVariables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OutputVariables
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
