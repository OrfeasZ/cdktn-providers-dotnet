using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.ActionGatewayEndpoint
{
    [JsiiClass(nativeType: typeof(digitalocean.ActionGatewayEndpoint.ActionGatewayEndpointVersionOutputReference), fullyQualifiedName: "digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ActionGatewayEndpointVersionOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ActionGatewayEndpointVersionOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActionGatewayEndpointVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActionGatewayEndpointVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putNetwork", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetwork\"}}]")]
        public virtual void PutNetwork(digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicy\"}}]")]
        public virtual void PutPolicy(digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActorId")]
        public virtual void ResetActorId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfig")]
        public virtual void ResetConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetwork")]
        public virtual void ResetNetwork()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTools")]
        public virtual void ResetTools()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "network", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetworkOutputReference\"}")]
        public virtual digitalocean.ActionGatewayEndpoint.ActionGatewayEndpointVersionNetworkOutputReference Network
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayEndpoint.ActionGatewayEndpointVersionNetworkOutputReference>()!;
        }

        [JsiiProperty(name: "pinnedTools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PinnedTools
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "policy", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicyOutputReference\"}")]
        public virtual digitalocean.ActionGatewayEndpoint.ActionGatewayEndpointVersionPolicyOutputReference Policy
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayEndpoint.ActionGatewayEndpointVersionPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "promotedFromVersionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PromotedFromVersionNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "versionNumber", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double VersionNumber
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "actorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInput", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionNetwork\"}", isOptional: true)]
        public virtual digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork? NetworkInput
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionNetwork?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersionPolicy\"}", isOptional: true)]
        public virtual digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy? PolicyInput
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersionPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "toolsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ToolsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "actorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "config", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Config
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tools", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Tools
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.actionGatewayEndpoint.ActionGatewayEndpointVersion\"}", isOptional: true)]
        public virtual digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersion? InternalValue
        {
            get => GetInstanceProperty<digitalocean.ActionGatewayEndpoint.IActionGatewayEndpointVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
