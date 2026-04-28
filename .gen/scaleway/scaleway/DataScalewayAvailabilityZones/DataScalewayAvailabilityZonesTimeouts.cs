using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayAvailabilityZones
{
    [JsiiByValue(fqn: "scaleway.dataScalewayAvailabilityZones.DataScalewayAvailabilityZonesTimeouts")]
    public class DataScalewayAvailabilityZonesTimeouts : scaleway.DataScalewayAvailabilityZones.IDataScalewayAvailabilityZonesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/data-sources/availability_zones#read DataScalewayAvailabilityZones#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
