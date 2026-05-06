using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiInterface(nativeType: typeof(IJmsTaskScheduleTaskDetails), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetails")]
    public interface IJmsTaskScheduleTaskDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#task_type JmsTaskSchedule#task_type}.</summary>
        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        string TaskType
        {
            get;
        }

        /// <summary>add_installation_site_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#add_installation_site_task_request JmsTaskSchedule#add_installation_site_task_request}
        /// </remarks>
        [JsiiProperty(name: "addInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest? AddInstallationSiteTaskRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>crypto_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#crypto_task_request JmsTaskSchedule#crypto_task_request}
        /// </remarks>
        [JsiiProperty(name: "cryptoTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest? CryptoTaskRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>deployed_application_migration_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#deployed_application_migration_task_request JmsTaskSchedule#deployed_application_migration_task_request}
        /// </remarks>
        [JsiiProperty(name: "deployedApplicationMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest? DeployedApplicationMigrationTaskRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>java_migration_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#java_migration_task_request JmsTaskSchedule#java_migration_task_request}
        /// </remarks>
        [JsiiProperty(name: "javaMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequest? JavaMigrationTaskRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>jfr_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jfr_task_request JmsTaskSchedule#jfr_task_request}
        /// </remarks>
        [JsiiProperty(name: "jfrTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest? JfrTaskRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>performance_tuning_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#performance_tuning_task_request JmsTaskSchedule#performance_tuning_task_request}
        /// </remarks>
        [JsiiProperty(name: "performanceTuningTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest? PerformanceTuningTaskRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>remove_installation_site_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#remove_installation_site_task_request JmsTaskSchedule#remove_installation_site_task_request}
        /// </remarks>
        [JsiiProperty(name: "removeInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest? RemoveInstallationSiteTaskRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>scan_java_server_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#scan_java_server_task_request JmsTaskSchedule#scan_java_server_task_request}
        /// </remarks>
        [JsiiProperty(name: "scanJavaServerTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest? ScanJavaServerTaskRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>scan_library_task_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#scan_library_task_request JmsTaskSchedule#scan_library_task_request}
        /// </remarks>
        [JsiiProperty(name: "scanLibraryTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest? ScanLibraryTaskRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IJmsTaskScheduleTaskDetails), fullyQualifiedName: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetails")]
        internal sealed class _Proxy : DeputyBase, oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#task_type JmsTaskSchedule#task_type}.</summary>
            [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>add_installation_site_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#add_installation_site_task_request JmsTaskSchedule#add_installation_site_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest? AddInstallationSiteTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsAddInstallationSiteTaskRequest?>();
            }

            /// <summary>crypto_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#crypto_task_request JmsTaskSchedule#crypto_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cryptoTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsCryptoTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest? CryptoTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsCryptoTaskRequest?>();
            }

            /// <summary>deployed_application_migration_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#deployed_application_migration_task_request JmsTaskSchedule#deployed_application_migration_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deployedApplicationMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest? DeployedApplicationMigrationTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsDeployedApplicationMigrationTaskRequest?>();
            }

            /// <summary>java_migration_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#java_migration_task_request JmsTaskSchedule#java_migration_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "javaMigrationTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequest? JavaMigrationTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequest?>();
            }

            /// <summary>jfr_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#jfr_task_request JmsTaskSchedule#jfr_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jfrTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJfrTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest? JfrTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJfrTaskRequest?>();
            }

            /// <summary>performance_tuning_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#performance_tuning_task_request JmsTaskSchedule#performance_tuning_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "performanceTuningTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest? PerformanceTuningTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsPerformanceTuningTaskRequest?>();
            }

            /// <summary>remove_installation_site_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#remove_installation_site_task_request JmsTaskSchedule#remove_installation_site_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "removeInstallationSiteTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest? RemoveInstallationSiteTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsRemoveInstallationSiteTaskRequest?>();
            }

            /// <summary>scan_java_server_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#scan_java_server_task_request JmsTaskSchedule#scan_java_server_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scanJavaServerTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanJavaServerTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest? ScanJavaServerTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanJavaServerTaskRequest?>();
            }

            /// <summary>scan_library_task_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#scan_library_task_request JmsTaskSchedule#scan_library_task_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scanLibraryTaskRequest", typeJson: "{\"fqn\":\"oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsScanLibraryTaskRequest\"}", isOptional: true)]
            public oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest? ScanLibraryTaskRequest
            {
                get => GetInstanceProperty<oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsScanLibraryTaskRequest?>();
            }
        }
    }
}
