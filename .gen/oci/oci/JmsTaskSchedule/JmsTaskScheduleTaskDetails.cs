using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetails")]
    public class JmsTaskScheduleTaskDetails : oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#task_type JmsTaskSchedule#task_type}.</summary>
        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public string TaskType
        {
            get;
            set;
        }

        /// <summary>add_installation_site_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#add_installation_site_task_request JmsTaskSchedule#add_installation_site_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest? AddInstallationSiteTaskRequest
        {
            get;
            set;
        }

        /// <summary>crypto_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#crypto_task_request JmsTaskSchedule#crypto_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cryptoTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest? CryptoTaskRequest
        {
            get;
            set;
        }

        /// <summary>deployed_application_migration_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#deployed_application_migration_task_request JmsTaskSchedule#deployed_application_migration_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deployedApplicationMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest? DeployedApplicationMigrationTaskRequest
        {
            get;
            set;
        }

        /// <summary>java_migration_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#java_migration_task_request JmsTaskSchedule#java_migration_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "javaMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequest? JavaMigrationTaskRequest
        {
            get;
            set;
        }

        /// <summary>jfr_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jfr_task_request JmsTaskSchedule#jfr_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jfrTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest? JfrTaskRequest
        {
            get;
            set;
        }

        /// <summary>performance_tuning_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#performance_tuning_task_request JmsTaskSchedule#performance_tuning_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "performanceTuningTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest? PerformanceTuningTaskRequest
        {
            get;
            set;
        }

        /// <summary>remove_installation_site_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#remove_installation_site_task_request JmsTaskSchedule#remove_installation_site_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "removeInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest? RemoveInstallationSiteTaskRequest
        {
            get;
            set;
        }

        /// <summary>scan_java_server_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#scan_java_server_task_request JmsTaskSchedule#scan_java_server_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scanJavaServerTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest? ScanJavaServerTaskRequest
        {
            get;
            set;
        }

        /// <summary>scan_library_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#scan_library_task_request JmsTaskSchedule#scan_library_task_request}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scanLibraryTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequest\"}", isOptional: true)]
        public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest? ScanLibraryTaskRequest
        {
            get;
            set;
        }
    }
}
