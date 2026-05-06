using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiByValue(fqn: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata")]
    public class DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata : oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata
    {
        /// <summary>aggregator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#aggregator DataintegrationWorkspaceApplicationTaskSchedule#aggregator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "aggregator", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator? Aggregator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#aggregator_key DataintegrationWorkspaceApplicationTaskSchedule#aggregator_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aggregatorKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AggregatorKey
        {
            get;
            set;
        }

        /// <summary>count_statistics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#count_statistics DataintegrationWorkspaceApplicationTaskSchedule#count_statistics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "countStatistics", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics\"}", isOptional: true)]
        public oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics? CountStatistics
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#created_by DataintegrationWorkspaceApplicationTaskSchedule#created_by}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedBy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#created_by_name DataintegrationWorkspaceApplicationTaskSchedule#created_by_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "createdByName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CreatedByName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#identifier_path DataintegrationWorkspaceApplicationTaskSchedule#identifier_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identifierPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdentifierPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#info_fields DataintegrationWorkspaceApplicationTaskSchedule#info_fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "infoFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? InfoFields
        {
            get;
            set;
        }

        private object? _isFavorite;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#is_favorite DataintegrationWorkspaceApplicationTaskSchedule#is_favorite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isFavorite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsFavorite
        {
            get => _isFavorite;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isFavorite = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#labels DataintegrationWorkspaceApplicationTaskSchedule#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#registry_version DataintegrationWorkspaceApplicationTaskSchedule#registry_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "registryVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RegistryVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#time_created DataintegrationWorkspaceApplicationTaskSchedule#time_created}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeCreated
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#time_updated DataintegrationWorkspaceApplicationTaskSchedule#time_updated}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeUpdated
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#updated_by DataintegrationWorkspaceApplicationTaskSchedule#updated_by}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdatedBy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#updated_by_name DataintegrationWorkspaceApplicationTaskSchedule#updated_by_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "updatedByName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UpdatedByName
        {
            get;
            set;
        }
    }
}
