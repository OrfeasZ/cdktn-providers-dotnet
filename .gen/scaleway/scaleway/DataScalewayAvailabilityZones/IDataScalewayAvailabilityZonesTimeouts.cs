using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayAvailabilityZones
{
    [JsiiInterface(nativeType: typeof(IDataScalewayAvailabilityZonesTimeouts), fullyQualifiedName: "scaleway.dataScalewayAvailabilityZones.DataScalewayAvailabilityZonesTimeouts")]
    public interface IDataScalewayAvailabilityZonesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/availability_zones#read DataScalewayAvailabilityZones#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataScalewayAvailabilityZonesTimeouts), fullyQualifiedName: "scaleway.dataScalewayAvailabilityZones.DataScalewayAvailabilityZonesTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.DataScalewayAvailabilityZones.IDataScalewayAvailabilityZonesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/availability_zones#read DataScalewayAvailabilityZones#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
