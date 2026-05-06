using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ResourceSchedulerSchedule
{
    [JsiiInterface(nativeType: typeof(IResourceSchedulerScheduleResourcesParameters), fullyQualifiedName: "oci.resourceSchedulerSchedule.ResourceSchedulerScheduleResourcesParameters")]
    public interface IResourceSchedulerScheduleResourcesParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#parameter_type ResourceSchedulerSchedule#parameter_type}.</summary>
        [JsiiProperty(name: "parameterType", typeJson: "{\"primitive\":\"string\"}")]
        string ParameterType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#value ResourceSchedulerSchedule#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IResourceSchedulerScheduleResourcesParameters), fullyQualifiedName: "oci.resourceSchedulerSchedule.ResourceSchedulerScheduleResourcesParameters")]
        internal sealed class _Proxy : DeputyBase, oci.ResourceSchedulerSchedule.IResourceSchedulerScheduleResourcesParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#parameter_type ResourceSchedulerSchedule#parameter_type}.</summary>
            [JsiiProperty(name: "parameterType", typeJson: "{\"primitive\":\"string\"}")]
            public string ParameterType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/resource_scheduler_schedule#value ResourceSchedulerSchedule#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Value
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
