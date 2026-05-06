using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.JmsTaskSchedule
{
    [JsiiByValue(fqn: "oci.jmsTaskSchedule.JmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargets")]
    public class JmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargets : oci.JmsTaskSchedule.IJmsTaskScheduleTaskDetailsJavaMigrationTaskRequestTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#application_installation_key JmsTaskSchedule#application_installation_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationInstallationKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationInstallationKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#exclude_package_prefixes JmsTaskSchedule#exclude_package_prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludePackagePrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludePackagePrefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#include_package_prefixes JmsTaskSchedule#include_package_prefixes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includePackagePrefixes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? IncludePackagePrefixes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#managed_instance_id JmsTaskSchedule#managed_instance_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedInstanceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ManagedInstanceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#source_jdk_version JmsTaskSchedule#source_jdk_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sourceJdkVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SourceJdkVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/jms_task_schedule#target_jdk_version JmsTaskSchedule#target_jdk_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetJdkVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetJdkVersion
        {
            get;
            set;
        }
    }
}
