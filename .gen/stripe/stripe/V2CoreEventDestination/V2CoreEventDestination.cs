using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.V2CoreEventDestination
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_core_event_destination stripe_v2_core_event_destination}.</summary>
    [JsiiClass(nativeType: typeof(stripe.V2CoreEventDestination.V2CoreEventDestination), fullyQualifiedName: "stripe.v2CoreEventDestination.V2CoreEventDestination", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationConfig\"}}]")]
    public class V2CoreEventDestination : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_core_event_destination stripe_v2_core_event_destination} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public V2CoreEventDestination(Constructs.Construct scope, string id, stripe.V2CoreEventDestination.IV2CoreEventDestinationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, stripe.V2CoreEventDestination.IV2CoreEventDestinationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2CoreEventDestination(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected V2CoreEventDestination(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a V2CoreEventDestination resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the V2CoreEventDestination to import.</param>
        /// <param name="importFromId">The id of the existing V2CoreEventDestination that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the V2CoreEventDestination to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the V2CoreEventDestination to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/v2_core_event_destination#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing V2CoreEventDestination that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the V2CoreEventDestination to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(stripe.V2CoreEventDestination.V2CoreEventDestination), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAmazonEventbridge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationAmazonEventbridge\"}}]")]
        public virtual void PutAmazonEventbridge(stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebhookEndpoint", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationWebhookEndpoint\"}}]")]
        public virtual void PutWebhookEndpoint(stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAmazonEventbridge")]
        public virtual void ResetAmazonEventbridge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEventsFrom")]
        public virtual void ResetEventsFrom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotApiVersion")]
        public virtual void ResetSnapshotApiVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebhookEndpoint")]
        public virtual void ResetWebhookEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(stripe.V2CoreEventDestination.V2CoreEventDestination))!;

        [JsiiProperty(name: "amazonEventbridge", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationAmazonEventbridgeOutputReference\"}")]
        public virtual stripe.V2CoreEventDestination.V2CoreEventDestinationAmazonEventbridgeOutputReference AmazonEventbridge
        {
            get => GetInstanceProperty<stripe.V2CoreEventDestination.V2CoreEventDestinationAmazonEventbridgeOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webhookEndpoint", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationWebhookEndpointOutputReference\"}")]
        public virtual stripe.V2CoreEventDestination.V2CoreEventDestinationWebhookEndpointOutputReference WebhookEndpoint
        {
            get => GetInstanceProperty<stripe.V2CoreEventDestination.V2CoreEventDestinationWebhookEndpointOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "amazonEventbridgeInput", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationAmazonEventbridge\"}", isOptional: true)]
        public virtual stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge? AmazonEventbridgeInput
        {
            get => GetInstanceProperty<stripe.V2CoreEventDestination.IV2CoreEventDestinationAmazonEventbridge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledEventsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EnabledEventsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventPayloadInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EventPayloadInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "eventsFromInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? EventsFromInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotApiVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SnapshotApiVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webhookEndpointInput", typeJson: "{\"fqn\":\"stripe.v2CoreEventDestination.V2CoreEventDestinationWebhookEndpoint\"}", isOptional: true)]
        public virtual stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint? WebhookEndpointInput
        {
            get => GetInstanceProperty<stripe.V2CoreEventDestination.IV2CoreEventDestinationWebhookEndpoint?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabledEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledEvents
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventPayload", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EventPayload
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "eventsFrom", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EventsFrom
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotApiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SnapshotApiVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
