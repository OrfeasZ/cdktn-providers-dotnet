using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator")]
    public class DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator : oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#description DataintegrationWorkspaceApplicationTaskSchedule#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#identifier DataintegrationWorkspaceApplicationTaskSchedule#identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Identifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#key DataintegrationWorkspaceApplicationTaskSchedule#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#name DataintegrationWorkspaceApplicationTaskSchedule#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#type DataintegrationWorkspaceApplicationTaskSchedule#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
