using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreaminfluxdbDbCluster
{
    [JsiiInterface(nativeType: typeof(ITimestreaminfluxdbDbClusterMaintenanceSchedule), fullyQualifiedName: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterMaintenanceSchedule")]
    public interface ITimestreaminfluxdbDbClusterMaintenanceSchedule
    {
        /// <summary>The preferred maintenance window in the format ddd:HH:MM-ddd:HH:MM.</summary>
        /// <remarks>
        /// Day must be one of Mon, Tue, Wed, Thu, Fri, Sat, or Sun. Provide an empty
        /// string to let the system choose a window.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/timestreaminfluxdb_db_cluster#preferred_maintenance_window TimestreaminfluxdbDbCluster#preferred_maintenance_window}
        /// </remarks>
        [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}")]
        string PreferredMaintenanceWindow
        {
            get;
        }

        /// <summary>The IANA timezone identifier for the maintenance window. For 								example, America/New_York or UTC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/timestreaminfluxdb_db_cluster#timezone TimestreaminfluxdbDbCluster#timezone}
        /// </remarks>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        string Timezone
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreaminfluxdbDbClusterMaintenanceSchedule), fullyQualifiedName: "aws.timestreaminfluxdbDbCluster.TimestreaminfluxdbDbClusterMaintenanceSchedule")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreaminfluxdbDbCluster.ITimestreaminfluxdbDbClusterMaintenanceSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The preferred maintenance window in the format ddd:HH:MM-ddd:HH:MM.</summary>
            /// <remarks>
            /// Day must be one of Mon, Tue, Wed, Thu, Fri, Sat, or Sun. Provide an empty
            /// string to let the system choose a window.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/timestreaminfluxdb_db_cluster#preferred_maintenance_window TimestreaminfluxdbDbCluster#preferred_maintenance_window}
            /// </remarks>
            [JsiiProperty(name: "preferredMaintenanceWindow", typeJson: "{\"primitive\":\"string\"}")]
            public string PreferredMaintenanceWindow
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The IANA timezone identifier for the maintenance window. For 								example, America/New_York or UTC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/timestreaminfluxdb_db_cluster#timezone TimestreaminfluxdbDbCluster#timezone}
            /// </remarks>
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
            public string Timezone
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
