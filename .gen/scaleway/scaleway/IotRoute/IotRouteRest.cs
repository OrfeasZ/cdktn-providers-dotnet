using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotRoute
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.iotRoute.IotRouteRest")]
    public class IotRouteRest : scaleway.IotRoute.IIotRouteRest
    {
        /// <summary>The HTTP call extra headers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_route#headers IotRoute#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Headers
        {
            get;
            set;
        }

        /// <summary>The URI of the REST endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_route#uri IotRoute#uri}
        /// </remarks>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public string Uri
        {
            get;
            set;
        }

        /// <summary>The HTTP Verb used to call REST URI.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/iot_route#verb IotRoute#verb}
        /// </remarks>
        [JsiiProperty(name: "verb", typeJson: "{\"primitive\":\"string\"}")]
        public string Verb
        {
            get;
            set;
        }
    }
}
