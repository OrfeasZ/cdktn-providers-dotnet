using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace tailscale.DataTailscaleDevices
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "tailscale.dataTailscaleDevices.DataTailscaleDevicesFilter")]
    public class DataTailscaleDevicesFilter : tailscale.DataTailscaleDevices.IDataTailscaleDevicesFilter
    {
        /// <summary>The name must be a top-level device property, e.g. isEphemeral, tags, hostname, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/data-sources/devices#name DataTailscaleDevices#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The list of values to filter for. Values are matched as exact matches.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/tailscale/tailscale/0.29.2/docs/data-sources/devices#values DataTailscaleDevices#values}
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
