using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.VisualBuilderVbInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.visualBuilderVbInstance.VisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcns")]
    public class VisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcns : oci.VisualBuilderVbInstance.IVisualBuilderVbInstanceNetworkEndpointDetailsAllowlistedHttpVcns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#id VisualBuilderVbInstance#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/visual_builder_vb_instance#allowlisted_ip_cidrs VisualBuilderVbInstance#allowlisted_ip_cidrs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowlistedIpCidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowlistedIpCidrs
        {
            get;
            set;
        }
    }
}
