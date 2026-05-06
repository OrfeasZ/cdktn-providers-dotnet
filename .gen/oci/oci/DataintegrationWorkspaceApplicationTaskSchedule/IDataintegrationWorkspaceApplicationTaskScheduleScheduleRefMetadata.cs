using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataintegrationWorkspaceApplicationTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata")]
    public interface IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata
    {
        /// <summary>aggregator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#aggregator DataintegrationWorkspaceApplicationTaskSchedule#aggregator}
        /// </remarks>
        [JsiiProperty(name: "aggregator", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator? Aggregator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#aggregator_key DataintegrationWorkspaceApplicationTaskSchedule#aggregator_key}.</summary>
        [JsiiProperty(name: "aggregatorKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AggregatorKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>count_statistics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#count_statistics DataintegrationWorkspaceApplicationTaskSchedule#count_statistics}
        /// </remarks>
        [JsiiProperty(name: "countStatistics", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics? CountStatistics
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#created_by DataintegrationWorkspaceApplicationTaskSchedule#created_by}.</summary>
        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#created_by_name DataintegrationWorkspaceApplicationTaskSchedule#created_by_name}.</summary>
        [JsiiProperty(name: "createdByName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CreatedByName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#identifier_path DataintegrationWorkspaceApplicationTaskSchedule#identifier_path}.</summary>
        [JsiiProperty(name: "identifierPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdentifierPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#info_fields DataintegrationWorkspaceApplicationTaskSchedule#info_fields}.</summary>
        [JsiiProperty(name: "infoFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? InfoFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#is_favorite DataintegrationWorkspaceApplicationTaskSchedule#is_favorite}.</summary>
        [JsiiProperty(name: "isFavorite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsFavorite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#labels DataintegrationWorkspaceApplicationTaskSchedule#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#registry_version DataintegrationWorkspaceApplicationTaskSchedule#registry_version}.</summary>
        [JsiiProperty(name: "registryVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RegistryVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#time_created DataintegrationWorkspaceApplicationTaskSchedule#time_created}.</summary>
        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeCreated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#time_updated DataintegrationWorkspaceApplicationTaskSchedule#time_updated}.</summary>
        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeUpdated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#updated_by DataintegrationWorkspaceApplicationTaskSchedule#updated_by}.</summary>
        [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdatedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#updated_by_name DataintegrationWorkspaceApplicationTaskSchedule#updated_by_name}.</summary>
        [JsiiProperty(name: "updatedByName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UpdatedByName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata), fullyQualifiedName: "oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata")]
        internal sealed class _Proxy : DeputyBase, oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadata
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aggregator block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#aggregator DataintegrationWorkspaceApplicationTaskSchedule#aggregator}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "aggregator", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator? Aggregator
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataAggregator?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#aggregator_key DataintegrationWorkspaceApplicationTaskSchedule#aggregator_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aggregatorKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AggregatorKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>count_statistics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#count_statistics DataintegrationWorkspaceApplicationTaskSchedule#count_statistics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "countStatistics", typeJson: "{\"fqn\":\"oci.dataintegrationWorkspaceApplicationTaskSchedule.DataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics\"}", isOptional: true)]
            public oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics? CountStatistics
            {
                get => GetInstanceProperty<oci.DataintegrationWorkspaceApplicationTaskSchedule.IDataintegrationWorkspaceApplicationTaskScheduleScheduleRefMetadataCountStatistics?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#created_by DataintegrationWorkspaceApplicationTaskSchedule#created_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#created_by_name DataintegrationWorkspaceApplicationTaskSchedule#created_by_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "createdByName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CreatedByName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#identifier_path DataintegrationWorkspaceApplicationTaskSchedule#identifier_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "identifierPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdentifierPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#info_fields DataintegrationWorkspaceApplicationTaskSchedule#info_fields}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "infoFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? InfoFields
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#is_favorite DataintegrationWorkspaceApplicationTaskSchedule#is_favorite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isFavorite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsFavorite
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#labels DataintegrationWorkspaceApplicationTaskSchedule#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Labels
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#registry_version DataintegrationWorkspaceApplicationTaskSchedule#registry_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "registryVersion", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RegistryVersion
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#time_created DataintegrationWorkspaceApplicationTaskSchedule#time_created}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeCreated
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#time_updated DataintegrationWorkspaceApplicationTaskSchedule#time_updated}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeUpdated
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#updated_by DataintegrationWorkspaceApplicationTaskSchedule#updated_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updatedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdatedBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/dataintegration_workspace_application_task_schedule#updated_by_name DataintegrationWorkspaceApplicationTaskSchedule#updated_by_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "updatedByName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UpdatedByName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
