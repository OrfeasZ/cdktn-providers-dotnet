using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceSchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.resourceSchedulerSchedule.ResourceSchedulerScheduleResourcesParameters")]
    public class ResourceSchedulerScheduleResourcesParameters : oci.ResourceSchedulerSchedule.IResourceSchedulerScheduleResourcesParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#parameter_type ResourceSchedulerSchedule#parameter_type}.</summary>
        [JsiiProperty(name: "parameterType", typeJson: "{\"primitive\":\"string\"}")]
        public string ParameterType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#value ResourceSchedulerSchedule#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Value
        {
            get;
            set;
        }
    }
}
