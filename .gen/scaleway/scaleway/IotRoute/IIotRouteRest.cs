using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.IotRoute
{
    [JsiiInterface(nativeType: typeof(IIotRouteRest), fullyQualifiedName: "scaleway.iotRoute.IotRouteRest")]
    public interface IIotRouteRest
    {
        /// <summary>The HTTP call extra headers.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#headers IotRoute#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        System.Collections.Generic.IDictionary<string, string> Headers
        {
            get;
        }

        /// <summary>The URI of the REST endpoint.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#uri IotRoute#uri}
        /// </remarks>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        string Uri
        {
            get;
        }

        /// <summary>The HTTP Verb used to call REST URI.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#verb IotRoute#verb}
        /// </remarks>
        [JsiiProperty(name: "verb", typeJson: "{\"primitive\":\"string\"}")]
        string Verb
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIotRouteRest), fullyQualifiedName: "scaleway.iotRoute.IotRouteRest")]
        internal sealed class _Proxy : DeputyBase, scaleway.IotRoute.IIotRouteRest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The HTTP call extra headers.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#headers IotRoute#headers}
            /// </remarks>
            [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
            public System.Collections.Generic.IDictionary<string, string> Headers
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            }

            /// <summary>The URI of the REST endpoint.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#uri IotRoute#uri}
            /// </remarks>
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
            public string Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The HTTP Verb used to call REST URI.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/iot_route#verb IotRoute#verb}
            /// </remarks>
            [JsiiProperty(name: "verb", typeJson: "{\"primitive\":\"string\"}")]
            public string Verb
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
