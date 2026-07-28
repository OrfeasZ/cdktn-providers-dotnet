using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WebPubsubSocketio
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.webPubsubSocketio.WebPubsubSocketioSku")]
    public class WebPubsubSocketioSku : azurerm.WebPubsubSocketio.IWebPubsubSocketioSku
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/web_pubsub_socketio#name WebPubsubSocketio#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.0.0/docs/resources/web_pubsub_socketio#capacity WebPubsubSocketio#capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Capacity
        {
            get;
            set;
        }
    }
}
