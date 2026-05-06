using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct")]
    public class DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct : oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatisticsObjectTypeCountListStruct
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#object_count DataintegrationWorkspaceApplicationTaskSchedule#object_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectCount", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#object_type DataintegrationWorkspaceApplicationTaskSchedule#object_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "objectType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ObjectType
        {
            get;
            set;
        }
    }
}
