using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics")]
    public interface IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics
    {
        /// <summary>object_type_count_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#object_type_count_list DataintegrationWorkspaceApplicationTaskSchedule#object_type_count_list}
        /// </remarks>
        [JsiiProperty(name: "objectTypeCountList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct\"},\"kind\":\"array\"}}]}}")]
        object ObjectTypeCountList
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>object_type_count_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#object_type_count_list DataintegrationWorkspaceApplicationTaskSchedule#object_type_count_list}
            /// </remarks>
            [JsiiProperty(name: "objectTypeCountList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct\"},\"kind\":\"array\"}}]}}")]
            public object ObjectTypeCountList
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
