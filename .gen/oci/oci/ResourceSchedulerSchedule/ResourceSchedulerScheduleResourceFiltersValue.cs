using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceSchedulerSchedule
{
    [JsiiByValue(fqn: "oci.resourceSchedulerSchedule.ResourceSchedulerScheduleResourceFiltersValue")]
    public class ResourceSchedulerScheduleResourceFiltersValue : oci.ResourceSchedulerSchedule.IResourceSchedulerScheduleResourceFiltersValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#namespace ResourceSchedulerSchedule#namespace}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#tag_key ResourceSchedulerSchedule#tag_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#value ResourceSchedulerSchedule#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
