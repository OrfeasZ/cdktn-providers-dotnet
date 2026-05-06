using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceSchedulerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.resourceSchedulerSchedule.ResourceSchedulerScheduleResources")]
    public class ResourceSchedulerScheduleResources : oci.ResourceSchedulerSchedule.IResourceSchedulerScheduleResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#id ResourceSchedulerSchedule#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#metadata ResourceSchedulerSchedule#metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        private object? _parameters;

        /// <summary>parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#parameters ResourceSchedulerSchedule#parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.resourceSchedulerSchedule.ResourceSchedulerScheduleResourcesParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Parameters
        {
            get => _parameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ResourceSchedulerSchedule.IResourceSchedulerScheduleResourcesParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ResourceSchedulerSchedule.IResourceSchedulerScheduleResourcesParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _parameters = value;
            }
        }
    }
}
