using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.DataScalewayIpamIp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.dataScalewayIpamIp.DataScalewayIpamIpResource")]
    public class DataScalewayIpamIpResource : scaleway.DataScalewayIpamIp.IDataScalewayIpamIpResource
    {
        /// <summary>Type of resource to filter for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/ipam_ip#type DataScalewayIpamIp#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>ID of the resource to filter for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/ipam_ip#id DataScalewayIpamIp#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Id
        {
            get;
            set;
        }

        /// <summary>Name of the resource to filter for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/data-sources/ipam_ip#name DataScalewayIpamIp#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
