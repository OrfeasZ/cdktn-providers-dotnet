using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct")]
    public interface IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#object_count DataintegrationWorkspaceApplicationTaskSchedule#object_count}.</summary>
        [JsiiProperty(name: "objectCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#object_type DataintegrationWorkspaceApplicationTaskSchedule#object_type}.</summary>
        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ObjectType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#object_count DataintegrationWorkspaceApplicationTaskSchedule#object_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectCount
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#object_type DataintegrationWorkspaceApplicationTaskSchedule#object_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ObjectType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
