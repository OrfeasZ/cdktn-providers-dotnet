using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Container
{
    [JsiiInterface(nativeType: typeof(IContainerScalingOption), fullyQualifiedName: "scaleway.container.ContainerScalingOption")]
    public interface IContainerScalingOption
    {
        /// <summary>Scale depending on the number of concurrent requests being processed per container instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/container#concurrent_requests_threshold Container#concurrent_requests_threshold}
        /// </remarks>
        [JsiiProperty(name: "concurrentRequestsThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConcurrentRequestsThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Scale depending on the CPU usage of a container instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/container#cpu_usage_threshold Container#cpu_usage_threshold}
        /// </remarks>
        [JsiiProperty(name: "cpuUsageThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuUsageThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Scale depending on the memory usage of a container instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/container#memory_usage_threshold Container#memory_usage_threshold}
        /// </remarks>
        [JsiiProperty(name: "memoryUsageThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryUsageThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerScalingOption), fullyQualifiedName: "scaleway.container.ContainerScalingOption")]
        internal sealed class _Proxy : DeputyBase, scaleway.Container.IContainerScalingOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Scale depending on the number of concurrent requests being processed per container instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/container#concurrent_requests_threshold Container#concurrent_requests_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "concurrentRequestsThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConcurrentRequestsThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Scale depending on the CPU usage of a container instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/container#cpu_usage_threshold Container#cpu_usage_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cpuUsageThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuUsageThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Scale depending on the memory usage of a container instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/container#memory_usage_threshold Container#memory_usage_threshold}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "memoryUsageThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryUsageThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
