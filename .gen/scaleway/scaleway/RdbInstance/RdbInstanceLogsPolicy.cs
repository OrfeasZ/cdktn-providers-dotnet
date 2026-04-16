using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbInstance
{
    [JsiiByValue(fqn: "scaleway.rdbInstance.RdbInstanceLogsPolicy")]
    public class RdbInstanceLogsPolicy : scaleway.RdbInstance.IRdbInstanceLogsPolicy
    {
        /// <summary>The max age (in days) of remote logs to keep on the Database Instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#max_age_retention RdbInstance#max_age_retention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxAgeRetention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAgeRetention
        {
            get;
            set;
        }

        /// <summary>The max disk size of remote logs to keep on the Database Instance.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#total_disk_retention RdbInstance#total_disk_retention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "totalDiskRetention", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TotalDiskRetention
        {
            get;
            set;
        }
    }
}
