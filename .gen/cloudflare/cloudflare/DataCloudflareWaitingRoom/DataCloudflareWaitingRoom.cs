using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareWaitingRoom
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/waiting_room cloudflare_waiting_room}.</summary>
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareWaitingRoom.DataCloudflareWaitingRoom), fullyQualifiedName: "cloudflare.dataCloudflareWaitingRoom.DataCloudflareWaitingRoom", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"cloudflare.dataCloudflareWaitingRoom.DataCloudflareWaitingRoomConfig\"}}]")]
    public class DataCloudflareWaitingRoom : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/waiting_room cloudflare_waiting_room} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataCloudflareWaitingRoom(Constructs.Construct scope, string id, cloudflare.DataCloudflareWaitingRoom.IDataCloudflareWaitingRoomConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, cloudflare.DataCloudflareWaitingRoom.IDataCloudflareWaitingRoomConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWaitingRoom(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareWaitingRoom(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataCloudflareWaitingRoom resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataCloudflareWaitingRoom to import.</param>
        /// <param name="importFromId">The id of the existing DataCloudflareWaitingRoom that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataCloudflareWaitingRoom to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataCloudflareWaitingRoom to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/waiting_room#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataCloudflareWaitingRoom that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataCloudflareWaitingRoom to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(cloudflare.DataCloudflareWaitingRoom.DataCloudflareWaitingRoom), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetZoneId")]
        public virtual void ResetZoneId()
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
        = GetStaticProperty<string>(typeof(cloudflare.DataCloudflareWaitingRoom.DataCloudflareWaitingRoom))!;

        [JsiiProperty(name: "additionalRoutes", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWaitingRoom.DataCloudflareWaitingRoomAdditionalRoutesList\"}")]
        public virtual cloudflare.DataCloudflareWaitingRoom.DataCloudflareWaitingRoomAdditionalRoutesList AdditionalRoutes
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWaitingRoom.DataCloudflareWaitingRoomAdditionalRoutesList>()!;
        }

        [JsiiProperty(name: "cookieAttributes", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareWaitingRoom.DataCloudflareWaitingRoomCookieAttributesOutputReference\"}")]
        public virtual cloudflare.DataCloudflareWaitingRoom.DataCloudflareWaitingRoomCookieAttributesOutputReference CookieAttributes
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareWaitingRoom.DataCloudflareWaitingRoomCookieAttributesOutputReference>()!;
        }

        [JsiiProperty(name: "cookieSuffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CookieSuffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customPageHtml", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomPageHtml
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultTemplateLanguage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultTemplateLanguage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disableSessionRenewal", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DisableSessionRenewal
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enabledOriginCommands", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EnabledOriginCommands
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Host
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jsonResponseEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JsonResponseEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "modifiedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModifiedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "newUsersPerMinute", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NewUsersPerMinute
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nextEventPrequeueStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextEventPrequeueStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nextEventStartTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NextEventStartTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queueAll", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable QueueAll
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "queueingMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QueueingMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queueingStatusCode", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueueingStatusCode
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "sessionDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "suspended", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Suspended
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "totalActiveUsers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalActiveUsers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "turnstileAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TurnstileAction
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "turnstileMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TurnstileMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "waitingRoomIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WaitingRoomIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "waitingRoomId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WaitingRoomId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
