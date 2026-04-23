using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectRoutingProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior")]
    public class ConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior : aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/connect_routing_profile#behavior_type ConnectRoutingProfile#behavior_type}.</summary>
        [JsiiProperty(name: "behaviorType", typeJson: "{\"primitive\":\"string\"}")]
        public string BehaviorType
        {
            get;
            set;
        }
    }
}
