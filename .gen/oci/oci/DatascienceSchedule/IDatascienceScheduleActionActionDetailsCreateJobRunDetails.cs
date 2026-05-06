using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceSchedule
{
    [JsiiInterface(nativeType: typeof(IDatascienceScheduleActionActionDetailsCreateJobRunDetails), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetails")]
    public interface IDatascienceScheduleActionActionDetailsCreateJobRunDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#compartment_id DatascienceSchedule#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#defined_tags DatascienceSchedule#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#display_name DatascienceSchedule#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#freeform_tags DatascienceSchedule#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_configuration_override_details DatascienceSchedule#job_configuration_override_details}
        /// </remarks>
        [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetails? JobConfigurationOverrideDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_environment_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_environment_configuration_override_details DatascienceSchedule#job_environment_configuration_override_details}
        /// </remarks>
        [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails? JobEnvironmentConfigurationOverrideDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_id DatascienceSchedule#job_id}.</summary>
        [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? JobId
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_log_configuration_override_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_log_configuration_override_details DatascienceSchedule#job_log_configuration_override_details}
        /// </remarks>
        [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetails? JobLogConfigurationOverrideDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#project_id DatascienceSchedule#project_id}.</summary>
        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProjectId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceScheduleActionActionDetailsCreateJobRunDetails), fullyQualifiedName: "oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#compartment_id DatascienceSchedule#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#defined_tags DatascienceSchedule#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#display_name DatascienceSchedule#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#freeform_tags DatascienceSchedule#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>job_configuration_override_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_configuration_override_details DatascienceSchedule#job_configuration_override_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetails\"}", isOptional: true)]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetails? JobConfigurationOverrideDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobConfigurationOverrideDetails?>();
            }

            /// <summary>job_environment_configuration_override_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_environment_configuration_override_details DatascienceSchedule#job_environment_configuration_override_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobEnvironmentConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails\"}", isOptional: true)]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails? JobEnvironmentConfigurationOverrideDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobEnvironmentConfigurationOverrideDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_id DatascienceSchedule#job_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "jobId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? JobId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>job_log_configuration_override_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#job_log_configuration_override_details DatascienceSchedule#job_log_configuration_override_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobLogConfigurationOverrideDetails", typeJson: "{\"fqn\":\"oci.datascienceSchedule.DatascienceScheduleActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetails\"}", isOptional: true)]
            public oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetails? JobLogConfigurationOverrideDetails
            {
                get => GetInstanceProperty<oci.DatascienceSchedule.IDatascienceScheduleActionActionDetailsCreateJobRunDetailsJobLogConfigurationOverrideDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_schedule#project_id DatascienceSchedule#project_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProjectId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
