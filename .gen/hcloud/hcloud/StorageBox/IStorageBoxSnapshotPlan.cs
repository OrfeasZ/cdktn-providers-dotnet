using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.StorageBox
{
    [JsiiInterface(nativeType: typeof(IStorageBoxSnapshotPlan), fullyQualifiedName: "hcloud.storageBox.StorageBoxSnapshotPlan")]
    public interface IStorageBoxSnapshotPlan
    {
        /// <summary>Hour when the Snapshot Plan is executed (UTC).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#hour StorageBox#hour}
        /// </remarks>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}")]
        double Hour
        {
            get;
        }

        /// <summary>Maximum amount of Snapshots that will be created by this Snapshot Plan. Older Snapshots will be deleted.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#max_snapshots StorageBox#max_snapshots}
        /// </remarks>
        [JsiiProperty(name: "maxSnapshots", typeJson: "{\"primitive\":\"number\"}")]
        double MaxSnapshots
        {
            get;
        }

        /// <summary>Minute when the Snapshot Plan is executed (UTC).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#minute StorageBox#minute}
        /// </remarks>
        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
        double Minute
        {
            get;
        }

        /// <summary>Day of the month when the Snapshot Plan is executed. Null means every day.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#day_of_month StorageBox#day_of_month}
        /// </remarks>
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DayOfMonth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Day of the week when the Snapshot Plan is executed.</summary>
        /// <remarks>
        /// Starts at 0 for Sunday til 6 for Saturday. Note that this differs from the API, which uses 1 (Monday) through 7 (Sunday). Null means every day.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#day_of_week StorageBox#day_of_week}
        /// </remarks>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBoxSnapshotPlan), fullyQualifiedName: "hcloud.storageBox.StorageBoxSnapshotPlan")]
        internal sealed class _Proxy : DeputyBase, hcloud.StorageBox.IStorageBoxSnapshotPlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Hour when the Snapshot Plan is executed (UTC).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#hour StorageBox#hour}
            /// </remarks>
            [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}")]
            public double Hour
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Maximum amount of Snapshots that will be created by this Snapshot Plan. Older Snapshots will be deleted.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#max_snapshots StorageBox#max_snapshots}
            /// </remarks>
            [JsiiProperty(name: "maxSnapshots", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxSnapshots
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Minute when the Snapshot Plan is executed (UTC).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#minute StorageBox#minute}
            /// </remarks>
            [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
            public double Minute
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Day of the month when the Snapshot Plan is executed. Null means every day.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#day_of_month StorageBox#day_of_month}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DayOfMonth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Day of the week when the Snapshot Plan is executed.</summary>
            /// <remarks>
            /// Starts at 0 for Sunday til 6 for Saturday. Note that this differs from the API, which uses 1 (Monday) through 7 (Sunday). Null means every day.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.60.1/docs/resources/storage_box#day_of_week StorageBox#day_of_week}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DayOfWeek
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
