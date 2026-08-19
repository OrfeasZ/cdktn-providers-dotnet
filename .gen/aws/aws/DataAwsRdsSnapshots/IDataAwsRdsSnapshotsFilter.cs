using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRdsSnapshots
{
    [JsiiInterface(nativeType: typeof(IDataAwsRdsSnapshotsFilter), fullyQualifiedName: "aws.dataAwsRdsSnapshots.DataAwsRdsSnapshotsFilter")]
    public interface IDataAwsRdsSnapshotsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/data-sources/rds_snapshots#name DataAwsRdsSnapshots#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/data-sources/rds_snapshots#values DataAwsRdsSnapshots#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsRdsSnapshotsFilter), fullyQualifiedName: "aws.dataAwsRdsSnapshots.DataAwsRdsSnapshotsFilter")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsRdsSnapshots.IDataAwsRdsSnapshotsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/data-sources/rds_snapshots#name DataAwsRdsSnapshots#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/data-sources/rds_snapshots#values DataAwsRdsSnapshots#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
