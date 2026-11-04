using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "digitalocean.actionGatewayConnection.ActionGatewayConnectionVpc")]
    public class ActionGatewayConnectionVpc : digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpc
    {
        private object _destination;

        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#destination ActionGatewayConnection#destination}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpcDestination" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.actionGatewayConnection.ActionGatewayConnectionVpcDestination\"},\"kind\":\"array\"}}]}}")]
        public object Destination
        {
            get => _destination;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpcDestination[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpcDestination).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.ActionGatewayConnection.IActionGatewayConnectionVpcDestination).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _destination = value;
            }
        }

        /// <summary>UUID of a VPC owned by your team.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.107.0/docs/resources/action_gateway_connection#vpc_uuid ActionGatewayConnection#vpc_uuid}
        /// </remarks>
        [JsiiProperty(name: "vpcUuid", typeJson: "{\"primitive\":\"string\"}")]
        public string VpcUuid
        {
            get;
            set;
        }
    }
}
