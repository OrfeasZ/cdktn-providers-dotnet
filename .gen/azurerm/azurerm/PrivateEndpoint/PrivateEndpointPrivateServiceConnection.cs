using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.privateEndpoint.PrivateEndpointPrivateServiceConnection")]
    public class PrivateEndpointPrivateServiceConnection : azurerm.PrivateEndpoint.IPrivateEndpointPrivateServiceConnection
    {
        private object _isManualConnection;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/private_endpoint#is_manual_connection PrivateEndpoint#is_manual_connection}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isManualConnection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IsManualConnection
        {
            get => _isManualConnection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isManualConnection = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/private_endpoint#private_connection_resource_alias PrivateEndpoint#private_connection_resource_alias}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateConnectionResourceAlias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateConnectionResourceAlias
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/private_endpoint#private_connection_resource_id PrivateEndpoint#private_connection_resource_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateConnectionResourceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateConnectionResourceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/private_endpoint#request_message PrivateEndpoint#request_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requestMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RequestMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.1.0/docs/resources/private_endpoint#subresource_names PrivateEndpoint#subresource_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subresourceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SubresourceNames
        {
            get;
            set;
        }
    }
}
