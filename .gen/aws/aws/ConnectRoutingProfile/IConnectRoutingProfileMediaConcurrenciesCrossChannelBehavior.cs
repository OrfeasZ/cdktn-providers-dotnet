using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectRoutingProfile
{
    [JsiiInterface(nativeType: typeof(IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior), fullyQualifiedName: "aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior")]
    public interface IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/connect_routing_profile#behavior_type ConnectRoutingProfile#behavior_type}.</summary>
        [JsiiProperty(name: "behaviorType", typeJson: "{\"primitive\":\"string\"}")]
        string BehaviorType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior), fullyQualifiedName: "aws.connectRoutingProfile.ConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior")]
        internal sealed class _Proxy : DeputyBase, aws.ConnectRoutingProfile.IConnectRoutingProfileMediaConcurrenciesCrossChannelBehavior
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/connect_routing_profile#behavior_type ConnectRoutingProfile#behavior_type}.</summary>
            [JsiiProperty(name: "behaviorType", typeJson: "{\"primitive\":\"string\"}")]
            public string BehaviorType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
