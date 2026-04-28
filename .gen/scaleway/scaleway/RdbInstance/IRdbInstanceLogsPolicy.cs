using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbInstance
{
    [JsiiInterface(nativeType: typeof(IRdbInstanceLogsPolicy), fullyQualifiedName: "scaleway.rdbInstance.RdbInstanceLogsPolicy")]
    public interface IRdbInstanceLogsPolicy
    {
        /// <summary>The max age (in days) of remote logs to keep on the Database Instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/rdb_instance#max_age_retention RdbInstance#max_age_retention}
        /// </remarks>
        [JsiiProperty(name: "maxAgeRetention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxAgeRetention
        {
            get
            {
                return null;
            }
        }

        /// <summary>The max disk size of remote logs to keep on the Database Instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/rdb_instance#total_disk_retention RdbInstance#total_disk_retention}
        /// </remarks>
        [JsiiProperty(name: "totalDiskRetention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TotalDiskRetention
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdbInstanceLogsPolicy), fullyQualifiedName: "scaleway.rdbInstance.RdbInstanceLogsPolicy")]
        internal sealed class _Proxy : DeputyBase, scaleway.RdbInstance.IRdbInstanceLogsPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The max age (in days) of remote logs to keep on the Database Instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/rdb_instance#max_age_retention RdbInstance#max_age_retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxAgeRetention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxAgeRetention
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The max disk size of remote logs to keep on the Database Instance.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/rdb_instance#total_disk_retention RdbInstance#total_disk_retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "totalDiskRetention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TotalDiskRetention
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
